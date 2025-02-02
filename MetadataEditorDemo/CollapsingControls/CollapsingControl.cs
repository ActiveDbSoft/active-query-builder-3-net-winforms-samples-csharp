//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.View.PropertiesEditors;

namespace MetadataEditorDemo.CollapsingControls {
    internal partial class CollapsingControl : UserControl {        
        private const int PaddingValue = 5;
        private Pen _borderPen;
        private readonly SolidBrush _containerBrush;
        private Size _previousParentSize = Size.Empty;
        private int _expandedHeight;
        private int _collapsedHeight;
        private bool _isExpanded;
        private ICollapsingDivider _collapsingDivider;
        private AnimationState _animationState;
        private int _animationHeightAdjustment;
        private Color _borderColor;
        private bool _canCollapse = true;
        private readonly Dictionary<Control, int> _controlHeights = new Dictionary<Control, int>();

        public CollapsingControl() {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);

            Height = 0;
            primaryPanel.Height = 0;
            dividerPanel.Height = 0;
            secondaryPanel.Height = 0;
            
            secondaryPanel.Padding = new Padding(0, PaddingValue, 0, 0);
            _containerBrush = new SolidBrush(Color.Transparent);

            CollapsedHeight = primaryPanel.Height + primaryPanel.Padding.Top + primaryPanel.Padding.Bottom
                + dividerPanel.Height + dividerPanel.Padding.Top + dividerPanel.Padding.Bottom
                + Padding.Top + Padding.Bottom;

            RecalcExpandHeight();
        }

        public event EventHandler<EventArgs> OnCollapse;
        public event EventHandler<EventArgs> OnExpand;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        protected ICollapsingDivider CollapsingDivider {
            get {
                return _collapsingDivider;
            }
            set {
                Control divider = _collapsingDivider as Control;
                if(divider != null) {
                    HideDivider();
                    dividerPanel.Controls.Remove(divider);
                }
                _collapsingDivider = value;
                if(_collapsingDivider == null) {
                    return;
                }
                _collapsingDivider = value;
                divider = _collapsingDivider as Control;
                if(divider != null) {
                    dividerPanel.Controls.Add(divider);
                    divider.Dock = DockStyle.Top;
                }
                ShowDivider();
                _collapsingDivider.CanCollapse = CanCollapse;
                if(_collapsingDivider.CanCollapse) {
                    _collapsingDivider.ButtonClick += CollapsingDividerButtonClick;
                }
            }
        }

        private void ShowDivider() {
            Control divider = _collapsingDivider as Control;
            if (secondaryPanel.Controls.Count > 0 && divider != null && dividerPanel.Height == 0) {
                UpdateHeights(divider, true);
            }
        }

        private void HideDivider() {
            Control divider = _collapsingDivider as Control;
            if (dividerPanel.Height > 0 && divider != null) {
                UpdateHeights(divider, false);
            }
        }

        private void UpdateHeights(Control newControl, bool isAdded) {
            if (isAdded) {
                newControl.Parent.Height += newControl.Height;
                ExpandedHeight = _expandedHeight + newControl.Height;
                CollapsedHeight = _collapsedHeight + newControl.Height;
                _controlHeights.Add(newControl, newControl.Height);
            }
            else {
                var controlHeight = _controlHeights[newControl];
                newControl.Parent.Height -= controlHeight;
                ExpandedHeight = _expandedHeight - controlHeight;
                CollapsedHeight = _collapsedHeight - controlHeight;
                _controlHeights.Remove(newControl);
            }
        }

        public void AddPrimaryControl(Control control) {
            if (control == null)
            {
                return;
            }
            primaryPanel.Controls.Add(control);
            primaryPanel.TabStop = true;
            control.TabIndex = primaryPanel.Controls.Count;
            control.Dock = DockStyle.Top;
            control.BringToFront();
            control.Resize += PropertyEditorResized;
            UpdateHeights(control, true);

            // add vertical margin
            UserControl blankControl = new UserControl
            {
                Size = new Size(0, 5),
                BackColor = Color.Transparent,
                TabIndex = primaryPanel.Controls.Count,
                TabStop = false
            };
            primaryPanel.Controls.Add(blankControl);
            blankControl.Dock = DockStyle.Top;
            blankControl.BringToFront();
            UpdateHeights(blankControl, true);
        }

        private void PropertyEditorResized(object sender, EventArgs e)
        {
            var senderAsControl = sender as Control;
            if (senderAsControl?.Parent == null) return;

            var calcExpandedHeight = _expandedHeight;
            var calcCollapsedHeight = _collapsedHeight;
            var calcParentHeight = senderAsControl.Parent.Height;

            var controlHeight = _controlHeights[senderAsControl];
            calcParentHeight -= controlHeight;
            calcExpandedHeight = calcExpandedHeight - controlHeight;
            calcCollapsedHeight = calcCollapsedHeight - controlHeight;

            calcParentHeight += senderAsControl.Height;
            calcExpandedHeight = calcExpandedHeight + senderAsControl.Height;
            calcCollapsedHeight = calcCollapsedHeight + senderAsControl.Height;
            _controlHeights[senderAsControl] = senderAsControl.Height;

            senderAsControl.Parent.Height = calcParentHeight;
            ExpandedHeight = calcExpandedHeight;
            CollapsedHeight = calcCollapsedHeight;
        }

        public void AddSecondaryControl(Control control) {
            if(control == null) {
                return;
            }
            secondaryPanel.Controls.Add(control);
            secondaryPanel.TabStop = IsExpanded;
            control.TabIndex = secondaryPanel.Controls.Count;
            control.Dock = DockStyle.Top;
            control.BringToFront();
            ExpandedHeight = _expandedHeight + control.Height;
            control.Resize += NestedSecondaryControl_Resize;

            // add vertical margin
            UserControl blankControl = new UserControl
            {
                Size = new Size(0, 5),
                BackColor = Color.Transparent,
                TabIndex = secondaryPanel.Controls.Count,
                TabStop = false
            };
            secondaryPanel.Controls.Add(blankControl);
            blankControl.Dock = DockStyle.Top;
            blankControl.BringToFront();
            ExpandedHeight = _expandedHeight + blankControl.Height;
            ShowDivider();
        }

        private void NestedSecondaryControl_Resize(object sender, EventArgs e) {
            RecalcExpandHeight();
        }

        private void RecalcExpandHeight() {
            _expandedHeight = _collapsedHeight + secondaryPanel.Padding.Top + secondaryPanel.Padding.Bottom;
            foreach(Control control in secondaryPanel.Controls) {
                _expandedHeight += control.Height;
            }
            if(_isExpanded) {
                Height = _expandedHeight;
            }
        }

        public int SecondaryControlsCount {
            get {
                return secondaryPanel.Controls.Count;
            }
        }

        private void CollapsingDividerButtonClick(object sender, EventArgs e) {
            IsExpanded = !IsExpanded;
        }

        private int CollapsedHeight {
            get { return _collapsedHeight; }
            set {
                if (_collapsedHeight == value) return;

                _collapsedHeight = value;
                if(!IsExpanded) {
                    Height = _collapsedHeight;
                }
            }
        }

        private int ExpandedHeight {
            get { return _expandedHeight; }
            set {
                if (_expandedHeight == value) return;

                _expandedHeight = value;
                if(IsExpanded) {
                    Height = _expandedHeight;
                }
            }
        }
       
        [DefaultValue(true)]
        public bool IsExpanded {
            get {
                return _isExpanded;
            }
            set {
                if(_isExpanded == value || (!value && !CanCollapse)) {
                    return;
                }
                _isExpanded = value;
                if(_collapsingDivider != null) {
                    _collapsingDivider.IsExpanded = value;
                }
                if(value) {
                    Expand();
                } else {
                    Collapse();
                }
            }
        }

        /// <summary>
        /// Expand panel content
        /// </summary>
        protected void Expand() {
            if(OnExpand != null) {
                OnExpand.Invoke(this, EventArgs.Empty);
            }
            _animationState = AnimationState.Expanding;
            StartAnimation();
            _collapsingDivider.OnExpand();
            secondaryPanel.TabStop = true;
        }

        /// <summary>
        /// Collapse panel content
        /// </summary>
        protected void Collapse() {
            if(!CanCollapse) {
                return;
            }
            if(OnCollapse != null) {
                OnCollapse.Invoke(this, EventArgs.Empty);
            }
            if(_animationState == AnimationState.Normal) {
                _expandedHeight = Height;
            }
            _animationState = AnimationState.Collapsing;
            StartAnimation();
            _collapsingDivider.OnCollapse();
            secondaryPanel.TabStop = false;
        }

        private bool _autoSizing;

        /// <summary>
        /// Handle panel resize event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if(_animationState != AnimationState.Normal) {
                return;
            }            
            if(_autoSizing) {
                _autoSizing = false;
                return;
            }
            if(IsExpanded && Height != _expandedHeight) {
                _autoSizing = true;
                Height = _expandedHeight;
            }
            if(!IsExpanded && Height != _collapsedHeight) {
                _autoSizing = true;
                Height = _collapsedHeight;
            }
            if(!IsExpanded && ((Anchor & AnchorStyles.Bottom) != 0) && Size.Height != _collapsedHeight && Parent != null) {
                _expandedHeight += Parent.Height - _previousParentSize.Height;
                Size = new Size(Size.Width, _collapsedHeight);
            }
            if(Parent != null) {
                _previousParentSize = Parent.Size;
            }
        }

        private void StartAnimation() {
            _animationHeightAdjustment = 1;
            animationTimer.Interval = 50;
            animationTimer.Enabled = true;
        }

        private void animationTimer_Tick(object sender, EventArgs e) {           
            if(animationTimer.Interval > 10) {
                animationTimer.Interval -= 10;
            } else {
                _animationHeightAdjustment += 10;
            }                        
            switch(_animationState) {
                case AnimationState.Expanding:
                    if(Height + _animationHeightAdjustment < _expandedHeight) {
                        Height += _animationHeightAdjustment;
                    } else {
                        Height = _expandedHeight;
                        _animationState = AnimationState.Normal;
                    }
                    break;
                case AnimationState.Collapsing:                    
                    if(Height - _animationHeightAdjustment > _collapsedHeight) {
                        Height -= _animationHeightAdjustment;
                    } else {
                        Height = _collapsedHeight;
                        _animationState = AnimationState.Normal;
                    }
                    break;
                default:
                    return;
            }
            if(_animationState == AnimationState.Normal) {
                animationTimer.Enabled = false;
            }
            Invalidate();
            PerformLayout();
        }

        public Color BorderColor {
            get {
                return _borderColor;
            }
            set {
                if(_borderColor == value) {
                    return;
                }
                if(value.IsEmpty) {
                    _borderPen.Dispose();
                    _borderPen = null;
                    if(!_borderColor.IsEmpty) {
                        CollapsedHeight = _collapsedHeight - 3;
                        Padding = new Padding(Padding.Left - 1, Padding.Top - 1, Padding.Right - 1, Padding.Bottom - 1);
                    }
                } else {
                    _borderPen = new Pen(value);
                    if(_borderColor.IsEmpty) {
                        CollapsedHeight = _collapsedHeight + 3;
                        Padding = new Padding(Padding.Left + 2, Padding.Top + 2, Padding.Right + 1, Padding.Bottom + 1);
                    }
                }
                _borderColor = value;
                Invalidate();
            }
        }

        public bool CanCollapse {
            get {
                return _canCollapse;
            }
            set {
                if(_canCollapse == value) {
                    return;
                }
                _canCollapse = value;
                if(_collapsingDivider != null) {
                    _collapsingDivider.CanCollapse = _canCollapse;
                }
                if(!value && !_isExpanded) {
                    IsExpanded = true;
                }
            }
        }

        private int BorderMargin {
            get {
                return BorderColor.IsEmpty ? 0 : 1;
            }
        }

        public Color PrimaryPanelColor {
            get {
                return primaryPanel.BackColor;
            }
            set {
                primaryPanel.BackColor = value;
            }
        }

        public Color SecondaryPanelColor {
            get {
                return secondaryPanel.BackColor;
            }
            set {
                secondaryPanel.BackColor = value;
            }
        }

        public Color DividerColor {
            get {
                return dividerPanel.BackColor;
            }
            set {
                dividerPanel.BackColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle fullRectangle = new Rectangle(
                BorderMargin,
                BorderMargin,
                Width,
                Height);
            g.FillRectangle(_containerBrush, fullRectangle);
            if(_borderPen != null && BorderColor != Color.Empty) {
                g.DrawRectangle(_borderPen, fullRectangle);
            }
        }

        private enum AnimationState {
            Normal,
            Expanding,
            Collapsing
        }
    }
}
