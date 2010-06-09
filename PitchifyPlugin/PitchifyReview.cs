﻿using System;
using System.Windows;
using Seesmic.Sdp.Extensibility;

namespace PitchifyPlugin
{
    public class PitchifyReview : ITimelineItem
    {
        public PitchifyReview()
        {
            Text = "Foobar";
        }

        public string Id { get; set; }

        public string Username { get; set; }

        public string Text { get; set; }

        public Uri SpotifyUri { get; set; }

        public Uri AvatarUri { get; set; }

        public DataTemplate Template { get { return PitchifyPlugin.TimelineItemTemplate; } }

        public DataTemplate NotificationTemplate { get { return null; } }

        public DateTimeOffset DateTime { get; set; }

        public GeoLocation GeoLocation { get { return null; } }
    }
}