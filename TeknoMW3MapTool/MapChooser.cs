using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TeknoMW3MapTool
{
    public partial class MapChooser : Form
    {
        public MapChooser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mapList = GetMapList();
            var gameModes = GetGameModes();

            var sb = new StringBuilder();

            foreach (var map in mapList)
            {
                foreach (var gameMode in gameModes)
                {
                    sb.Append(map);
                    sb.Append(',');
                    sb.Append(gameMode);
                    sb.Append(',');
                    sb.Append(1);
                    sb.Append(Environment.NewLine);
                }
            }

            var sfd = new SaveFileDialog
            {
                Filter = "MW3 Maplist (*.dspl)|*.dspl",
                FilterIndex = 0,
                Title = "Save Map List",
                DefaultExt = "dspl",
                FileName = "default",
                InitialDirectory = Environment.CurrentDirectory
            };
            var sfdDialogResult = sfd.ShowDialog();
            if (sfdDialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(sfd.FileName))
            {
                return;
            }

            using var fileStream = sfd.OpenFile();
            var bytes = Encoding.UTF8.GetBytes(sb.ToString());
            fileStream.Write(bytes);
        }

        private List<string> GetMapList()
        {
            var mapList = new List<string>();

            if (cbArkaden.Checked)
            {
                mapList.Add("mp_plaza2");
            }

            if (cbBakaara.Checked)
            {
                mapList.Add("mp_mogadishu");
            }

            if (cbBootleg.Checked)
            {
                mapList.Add("mp_bootleg");
            }

            if (cbCarbon.Checked)
            {
                mapList.Add("mp_carbon");
            }

            if (cbDome.Checked)
            {
                mapList.Add("mp_dome");
            }

            if (cbDownturn.Checked)
            {
                mapList.Add("mp_exchange");
            }

            if (cbFallen.Checked)
            {
                mapList.Add("mp_lambeth");
            }

            if (cbHardhat.Checked)
            {
                mapList.Add("mp_hardhat");
            }

            if (cbInterchange.Checked)
            {
                mapList.Add("mp_interchange");
            }

            if (cbLockdown.Checked)
            {
                mapList.Add("mp_alpha");
            }

            if (cbMission.Checked)
            {
                mapList.Add("mp_bravo");
            }

            if (cbOutpost.Checked)
            {
                mapList.Add("mp_radar");
            }

            if (cbResistance.Checked)
            {
                mapList.Add("mp_paris");
            }

            if (cbSeatown.Checked)
            {
                mapList.Add("mp_seatown");
            }

            if (cbUnderground.Checked)
            {
                mapList.Add("mp_underground");
            }

            if (cbVillage.Checked)
            {
                mapList.Add("mp_village");
            }

            return mapList;
        }

        private List<string> GetGameModes()
        {
            var gameModes = new List<string>();

            if (cbTDM.Checked)
            {
                gameModes.Add("TDM_default");
            }

            if (cbDom.Checked)
            {
                gameModes.Add("DOM_default");
            }

            if (cbCTF.Checked)
            {
                gameModes.Add("CTF_default");
            }

            if (cbDZ.Checked)
            {
                gameModes.Add("DZ_default");
            }

            if (cbFFA.Checked)
            {
                gameModes.Add("FFA_default");
            }

            if (cbGG.Checked)
            {
                gameModes.Add("GG_default");
            }

            if (cbHQ.Checked)
            {
                gameModes.Add("HQ_default");
            }

            if (cbInf.Checked)
            {
                gameModes.Add("INF_default");
            }

            if (cbJug.Checked)
            {
                gameModes.Add("JUG_default");
            }

            if (cbKC.Checked)
            {
                gameModes.Add("KC_default");
            }

            if (cbOIC.Checked)
            {
                gameModes.Add("OIC_default");
            }

            if (cbSab.Checked)
            {
                gameModes.Add("SAB_default");
            }

            if (cbSnD.Checked)
            {
                gameModes.Add("SD_default");
            }

            if (cbTDF.Checked)
            {
                gameModes.Add("TDEF_default");
            }

            if (cbTJug.Checked)
            {
                gameModes.Add("TJ_default");
            }

            return gameModes;
        }
    }
}