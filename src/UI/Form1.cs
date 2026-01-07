using System.IO;
using UI.Enums;

namespace UI
{
    public partial class Form1 : Form
    {
        private DirectoryInfo _source;
        private DirectoryInfo _output;
        private List<string> _extensions;
        private List<string> _folders;
        private int _filesCount;
        private int _foldersCount;

        public Form1()
        {
            InitializeComponent();
            ChangeStatus(StatusEnum.Ready);
            txtExtensions.Text = ".cs;.js;.json;.csproj";
            txtIgnoredFolders.Text = ".git;.github;.vs;bin;obj";
            pbLoad.Minimum = 1;
            pbLoad.Value = 1;
            pbLoad.Step = 1;
        }

        private void ChangeStatus(StatusEnum status)
        {
            txtStatus.Text = status.ToString();
            switch (status)
            {
                case StatusEnum.Ready:
                    txtStatus.BackColor = Color.Green;
                    break;
                case StatusEnum.Reading:
                    txtStatus.BackColor = Color.Yellow;
                    break;
                case StatusEnum.Processing:
                    txtStatus.BackColor = Color.Red;
                    break;
                case StatusEnum.Done:
                    txtStatus.BackColor = Color.Blue;
                    break;
                case StatusEnum.Reset:
                    txtStatus.Text = StatusEnum.Ready.ToString();
                    txtStatus.BackColor = Color.Green;
                    txtAppName.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                    txtExtensions.Text = string.Empty;
                    txtFilesCount.Text = string.Empty;
                    txtFoldersCount.Text = string.Empty;
                    txtIgnoredFolders.Text = string.Empty;
                    txtOutputDir.Text = string.Empty;
                    txtSourceDir.Text = string.Empty;
                    pbLoad.Step = 0;
                    ltbFilesProcessed.Items.Clear();
                    break;
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceDir.Text = dialog.SelectedPath.ToString();
                _source = new DirectoryInfo(txtSourceDir.Text);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputDir.Text = dialog.SelectedPath.ToString();
                _output = new DirectoryInfo(txtOutputDir.Text);
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusEnum.Reading);

            _extensions = txtExtensions.Text.Split(';').ToList();
            _folders = txtIgnoredFolders.Text.Split(';').ToList();

            var files = await GetFiles(_source);

            pbLoad.Maximum = files.Count;

            ChangeStatus(StatusEnum.Processing);

            await ProccessFiles(files);

            ChangeStatus(StatusEnum.Done);
        }

        private async Task<List<FileInfo>> GetFiles(DirectoryInfo directory)
        {
            if (_folders.Contains(directory.Name))
                return null;

            _foldersCount++;
            txtFoldersCount.Text = _folders.Count.ToString();

            var csFiles = directory.GetFiles().Where(x => _extensions.Contains(x.Extension)).ToList();
            _filesCount = _filesCount + csFiles.Count;
            txtFilesCount.Text = _filesCount.ToString();

            var folders = directory.GetDirectories().ToList();
            foreach (var folder in folders)
            {
                await Task.Delay(250);
                var files = await GetFiles(folder);
                if (files != null)
                    csFiles.AddRange(files);
            }
            return csFiles;
        }

        private async Task ProccessFiles(List<FileInfo> files)
        {
            var fileName = Path.Combine(_output.FullName, $"{txtAppName.Text.Replace(' ', '_')}_{DateTime.UtcNow.Ticks}.txt");

            FileStream stream = new FileStream(fileName, FileMode.CreateNew);

            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine(txtAppName.Text);
                writer.WriteLine(string.Empty);
                writer.WriteLine(string.Empty);
                writer.WriteLine(string.Empty);
                writer.WriteLine(txtDescription.Text);
                writer.WriteLine(string.Empty);
                writer.WriteLine(string.Empty);
                writer.WriteLine(string.Empty);

                foreach (var file in files)
                {
                    pbLoad.PerformStep();
                    await Task.Delay(250);
                    ltbFilesProcessed.Items.Add(file.FullName);
                    //ltbFilesProcessed.SelectedIndex = ltbFilesProcessed.Items.Count - 1;

                    writer.WriteLine(string.Empty);
                    writer.WriteLine(string.Empty);
                    writer.WriteLine(string.Empty);
                    writer.WriteLine("________________________________________________________________________________________________________________");
                    writer.WriteLine(file.FullName);
                    writer.WriteLine("");
                    StreamReader sr = new StreamReader(file.FullName);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                    writer.WriteLine("________________________________________________________________________________________________________________");
                    sr.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusEnum.Reset);
        }
    }
}
