﻿using System;

namespace TestStack.BDDfy
{
    public class StoryMetadata
    {
        public StoryMetadata(Type storyType, StoryNarrativeAttribute narrative)
            : this(storyType, narrative.Narrative1, narrative.Narrative2, narrative.Narrative3, narrative.Title)
        {
        }

        public StoryMetadata(Type storyType, string narrative1, string narrative2, string narrative3, string storyTitle = null)
        {
            Title = storyTitle ?? NetToString.Convert(storyType.Name);
            Type = storyType;

            Narrative1 = narrative1;
            Narrative2 = narrative2;
            Narrative3 = narrative3;
        }

        public Type Type { get; private set; }
        public string Title { get; private set; }
        public string Narrative1 { get; private set; }
        public string Narrative2 { get; private set; }
        public string Narrative3 { get; private set; }
    }
}