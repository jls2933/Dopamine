﻿namespace Dopamine.Common.Api.Lyrics
{
    public enum SourceTypeEnum
    {
        Audio,
        Lrc,
        Online
    }

    public class Lyrics
    {
        #region Variables
        private string text;
        private string source;
        #endregion

        #region Properties
        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public string Source
        {
            get { return this.source; }
        }

        public bool HasText
        {
            get { return !string.IsNullOrWhiteSpace(this.Text); }
        }

        public bool HasSource
        {
            get { return !string.IsNullOrWhiteSpace(this.source); }
        }

        public SourceTypeEnum SourceType { get; set; }
        #endregion

        #region Construction
        public Lyrics(string text, string source)
        {
            this.text = text;
            this.source = source;
        }
        #endregion
    }
}
