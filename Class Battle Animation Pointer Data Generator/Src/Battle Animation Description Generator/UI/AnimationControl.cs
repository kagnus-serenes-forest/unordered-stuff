using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI {
    public partial class AnimationControl : UserControl {

        public AnimationControl(Models.AnimationComponent ExposedComponent, String LabelContent) {
            InitializeComponent();
            AnimationNumber.DataBindings.Add("Value", ExposedComponent, "AnimationIndex");
            IncludeCheckBox.DataBindings.Add("Checked", ExposedComponent, "Included");
            WeaponTypeLabel.Text = LabelContent;
        }

    }
}
