﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDepend.Helpers.FileDirectoryPath;
using System.IO;

namespace JarrettVance.ChapterTools
{
    public partial class QuickOpenDialog : Form
    {
        public QuickOpenDialog()
        {
            InitializeComponent();

            QuickOpen(Settings.Default.QuickOpenDir);
        }

        public string DiscPath { get; protected set; }

        private void QuickOpen(string dir)
        {
            txtFolder.Text = dir;
            flowDiscs.Controls.Clear();

            if (string.IsNullOrEmpty(dir))
            {
                flowDiscs.Controls.Add(new ErrorItem("Please choose a folder containing your disc backups."));
                return;
            }

            try
            {
                var discs = new List<Disc>();
                var dirs = new DirectoryPathAbsolute(dir).ChildrenDirectoriesPath;

                foreach (var d in dirs)
                {
                    if (Directory.Exists(Path.Combine(d.Path, "VIDEO_TS")))
                    {
                        discs.Add(new Disc(d.Path, "DVD"));
                    }
                    else if (Directory.Exists(Path.Combine(Path.Combine(d.Path, "BDMV"), "PLAYLIST")))
                    {
                        discs.Add(new Disc(d.Path, "Bluray"));
                    }
                    else if (Directory.Exists(Path.Combine(d.Path, "ADV_OBJ")))
                    {
                        discs.Add(new Disc(d.Path, "HDDVD"));
                    }
                }

                foreach (var disc in discs)
                {
                    var di = new DiscItem(disc);
                    di.Opened += (s, e) =>
                        {
                            DiscPath = ((Disc)((DiscItem)s).Tag).Path;
                            DialogResult = DialogResult.OK;
                            Close();
                        };
                    flowDiscs.Controls.Add(di);
                }

                if (discs.Count == 0)
                {
                    flowDiscs.Controls.Add(new ErrorItem("No discs found.  Please select your backup folder containing discs."));
                }
            }
            catch (Exception ex)
            {
                flowDiscs.Controls.Add(new ErrorItem(ex.Message));
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog d = new FolderBrowserDialog())
            {
                d.Description = "Select a folder.";
                d.ShowNewFolderButton = false;
                if (d.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.QuickOpenDir = d.SelectedPath;
                    Settings.Default.Save();
                    QuickOpen(d.SelectedPath);
                }
            }
        }
    }

    public class Disc
    {
        public Disc(string path, string type)
        {

            var dir = new DirectoryPathAbsolute(path);
            Path = path;
            Type = type;
            Name = dir.DirectoryName;

            var exts = new List<string>();
            if (dir.ChildrenFilesPath.Any(x => x.FileExtension == ".xml"))
            {
                exts.Add("xml");
            }
            else if (dir.ChildrenFilesPath.Any(x => x.FileExtension == ".chapters"))
            {
                exts.Add("chapter");
            }
            else if (dir.ChildrenFilesPath.Any(x => x.FileExtension == ".txt"))
            {
                exts.Add("txt");
            }

            FoundExtractions = exts.ToArray();
        }
        public string Path { get; protected set; }
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string[] FoundExtractions { get; protected set; }
    }
}
