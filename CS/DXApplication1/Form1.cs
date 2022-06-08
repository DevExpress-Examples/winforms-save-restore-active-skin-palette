using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DXApplication1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1() {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SavePalette();
        }

        private void ShowSwatchPicker(Form owner) {
            using(var dialog = new DevExpress.Customization.SvgSkinPaletteSelector(owner)) {
                dialog.ShowDialog();
                SavePalette();
            }
        }

        private void SavePalette() {
            var settings = Properties.Settings.Default;
            settings.SkinName = UserLookAndFeel.Default.SkinName;
            settings.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName;
            settings.CompactMode = UserLookAndFeel.Default.CompactUIModeForced;
            settings.Save();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            RestorePalette();
            ShowSettings();
        }

        private void RestorePalette() {
            var settings = Properties.Settings.Default;
            if (!string.IsNullOrEmpty(settings.SkinName)) {
                if (settings.CompactMode)
                    UserLookAndFeel.ForceCompactUIMode(true, false);
                if (!string.IsNullOrEmpty(settings.Palette))
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName, settings.Palette);
                else UserLookAndFeel.Default.SetSkinStyle(settings.SkinName);
            }
        }

        private void ShowSettings() {
            labelControl1.Text = Settings.Default.SkinName;
            labelControl4.Text = Settings.Default.Palette != String.Empty ? Settings.Default.Palette : "n/a (default palette or raster skin)";
            labelControl6.Text = Settings.Default.CompactMode ? "Yes" : "No";
        }
    }
}
