using System;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;

using Video_Clicker.MVVM.Commands;
using Video_Clicker.MVVM.Config;

namespace Video_Clicker.MVVM.ViewModel
{
    public class MainWindowViewModel
    {
        public ICommand CmdClickerClick { get; private set; }
        public ICommand CmdLoaded { get; private set; }


        public MediaPlayer PlayerButtonSFX { get; private set; } = new();
        public MediaPlayer PlayerBGM { get; private set; } = new();


        public MainWindowViewModel()
        {
            CmdLoaded = new BaseCommand(
                (param) =>
                {
                    PlayerButtonSFX.Open(new Uri(FilePaths.PathButtonSFX));
                    PlayerButtonSFX.MediaEnded += (s, e) => PlayerButtonSFX.Stop();

                    PlayerBGM.Open(new Uri(FilePaths.PathBGM));
                    PlayerBGM.MediaEnded += (s, e) => PlayerBGM.Play();
                    PlayerBGM.Play();
                }
            );


            CmdClickerClick = new BaseCommand(
                (param) =>
                {
                    PlayerButtonSFX.Play();
                    Trace.WriteLine("Button Click Test");
                }
            );
        }
    }
}
