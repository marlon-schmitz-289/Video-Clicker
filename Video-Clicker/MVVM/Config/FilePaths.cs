using System;

namespace Video_Clicker.MVVM.Config
{
    public static class FilePaths
    {
        private static readonly string PathProject = $@"{Environment.CurrentDirectory}\..\..\..\";

        public static readonly string PathButtonSFX = $@"{PathProject}Assets\SFX\button_sfx.wav";
        public static readonly string PathBGM = $@"{PathProject}Assets\Music\bgm.wav";
    }
}
