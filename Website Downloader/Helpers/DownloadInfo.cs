﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteDownloader.Helpers
{
    class DownloadInfo
    {
        internal enum Status
        {
            UNSET = 0, // = DEFAULT VALUE, not yet queued
            QUEUED, // = waiting for finished worker thread
            WORKING, // = download in progress
            FINISHED, // = download finished
            ERROR
        }

        // ConcurrentBag = thread-safe list 
        internal Action Listener { get; } 
        internal string Source { get; }
        internal string Target { get; }
        internal Status DownloadStatus { get; set; }

        internal DownloadInfo(string source, string target, Action listener = null) // listener is optional
        {
            Source = source;
            Target = target;
            Listener = listener;
        }
    }
}