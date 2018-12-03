using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyHelpers;

namespace UI
{
    public partial class UIForm : Form
    {
        private Models.Animation Animation = new Models.Animation();
        private static readonly String[] names = new String[] {
            "Sword",
            "Lance",
            "Axe",
            "Bow",
            "Staff",
            "Anima",
            "Light",
            "Dark",
            "Disarmed"
        };

        public UIForm()
        {
            InitializeComponent();
            int i = 0;
            int y = 0;
            int x = 0;
            foreach (Models.AnimationComponent component in Animation.DefaultComponents()) {
                if (component != null) {
                    var tmp = new AnimationControl(component, names[i++]);
                    //tmp.Location = new Point(0, tmp.Height * (i - 1));
                    if (y == 0) {
                        y = tmp.Height;
                        x = tmp.Width;
                    }
                    this.UIMainContainer.Controls.Add(tmp);
                }
            }
            var b = new Button() {
                Text = "Test"//,
                //Location = new Point(x, y)
            };
            b.Click += new EventHandler((sender, e) => {
                int c = 0;
                var l = new List<byte>();
                foreach (Models.AnimationComponent comp in Animation.DefaultComponents()) {
                    if (comp != null) {
                        if (comp.Included) {
                            c++;
                            l.AddRange(comp.Bytes);
                        }
                    }
                }
                l.AddRange(BitConverter.GetBytes(0));
                MessageBox.Show("Counted " + c + " included");
                var s = l.ToArray().ToHexString();
                MessageBox.Show(s);
                Clipboard.SetText(s);
            });
            this.UIMainContainer.Controls.Add(b);
        }
    }
}
