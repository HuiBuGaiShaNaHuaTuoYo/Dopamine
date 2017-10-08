﻿using Digimezzo.WPFControls.Enums;
using Prism.Events;

namespace Dopamine.Common.Prism
{
    public class OobeNavigatedToEvent : PubSubEvent<string>
    {
    }

    public class CloseOobeEvent : PubSubEvent<object>
    {
    }

    public class ChangeOobeSlideDirectionEvent : PubSubEvent<SlideDirection>
    {
    }

    public class ScrollToPlayingTrack : PubSubEvent<object>
    {
    }

    public class ScrollToHighlightedLyricsLine : PubSubEvent<object>
    {
    }

    public class CoverPlayerPlaylistButtonClicked : PubSubEvent<bool>
    {
    }

    public class MicroPlayerPlaylistButtonClicked : PubSubEvent<bool>
    {
    }

    public class NanoPlayerPlaylistButtonClicked : PubSubEvent<bool>
    {
    }

    public class SelectedSpectrumStyleChanged : PubSubEvent<string>
    {
    }

    public class ToggledCoverPlayerAlignPlaylistVertically : PubSubEvent<bool>
    {
    }

    public class ShellMouseUp : PubSubEvent<string>
    {
    }

    public class LyricsScreenIsActiveChanged : PubSubEvent<bool>
    {
    }

    public class NowPlayingIsSelectedChanged : PubSubEvent<bool>
    {
    }
}
