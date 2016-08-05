﻿using Prism.Commands;

namespace Dopamine.Core.Prism
{
    public sealed class ApplicationCommands
    {
        public static CompositeCommand NavigateToMainScreenCommand = new CompositeCommand();
        public static CompositeCommand NavigateToNowPlayingScreenCommand = new CompositeCommand();
        public static CompositeCommand NavigateBetweenCollectionCommand = new CompositeCommand();
        public static CompositeCommand NavigateBetweenSettingsCommand = new CompositeCommand();
        public static CompositeCommand NavigateBetweenInformationCommand = new CompositeCommand();
        public static CompositeCommand NavigateBetweenMainCommand = new CompositeCommand();
        public static CompositeCommand OpenLinkCommand = new CompositeCommand();
        public static CompositeCommand OpenMailCommand = new CompositeCommand();
        public static CompositeCommand OpenPathCommand = new CompositeCommand();
        public static CompositeCommand TaskbarItemInfoPlayCommand = new CompositeCommand();
        public static CompositeCommand RestoreWindowCommand = new CompositeCommand();
        public static CompositeCommand MinimizeWindowCommand = new CompositeCommand();
        public static CompositeCommand MaximizeRestoreWindowCommand = new CompositeCommand();
        public static CompositeCommand CloseWindowCommand = new CompositeCommand();
        public static CompositeCommand FullPlayerShowcaseButtonCommand = new CompositeCommand();
        public static CompositeCommand CoverPlayerPlaylistButtonCommand = new CompositeCommand();
        public static CompositeCommand MicroPlayerPlaylistButtonCommand = new CompositeCommand();
        public static CompositeCommand NanoPlayerPlaylistButtonCommand = new CompositeCommand();
        public static CompositeCommand RemoveSelectedTracksCommand = new CompositeCommand();
        public static CompositeCommand ChangePlayerTypeCommand = new CompositeCommand();
        public static CompositeCommand ToggleMiniPlayerPositionLockedCommand = new CompositeCommand();
        public static CompositeCommand ToggleMiniPlayerAlwaysOnTopCommand = new CompositeCommand();
        public static CompositeCommand ToggleAlwaysShowPlaybackInfoCommand = new CompositeCommand();
        public static CompositeCommand ToggleAlignPlaylistVerticallyCommand = new CompositeCommand();
        public static CompositeCommand TogglePlayerCommand = new CompositeCommand();
        public static CompositeCommand SemanticJumpCommand = new CompositeCommand();
        public static CompositeCommand ShowMainWindowCommand = new CompositeCommand();
    }
}