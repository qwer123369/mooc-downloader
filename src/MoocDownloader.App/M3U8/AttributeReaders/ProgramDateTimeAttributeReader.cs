﻿using MoocDownloader.App.M3U8.Core;
using MoocDownloader.App.M3U8.Utilities;
using System;

namespace MoocDownloader.App.M3U8.AttributeReaders
{
    internal class ProgramDateTimeAttributeReader : AttributeReader
    {
        protected override bool CanRead(string key)
        {
            return string.Equals("#EXT-X-PROGRAM-DATE-TIME", key);
        }

        protected override void Write(M3UFileInfo fileInfo, string value, LineReader reader)
        {
            fileInfo.ProgramDateTime = To.Value<DateTime>(value);
        }
    }
}