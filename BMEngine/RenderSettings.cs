﻿using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithEngine
{
    public enum KeyboardRenderers
    {
        Legacy,
        New,
        Flat
    }

    public enum NoteRenderers
    {
        Shaded,
        Flat
    }

    public class RenderSettings
    {
        public int fps = 60;

        public int width = 1920;
        public int height = 1080;
        public int downscale = 1;

        public bool ffRender = false;
        public string ffPath = "";
        public bool ffRenderMask = false;
        public string ffMaskPath = "";
        public bool vsync = false;
        public double renderSecondsDelay = 0;

        private bool paused = false;
        public bool forceReRender = true;
        public double tempoMultiplier = 1;

        public bool includeAudio = false;
        public string audioPath = "";

        public int maxTrackBufferSize = 10000;

        public bool useBitrate = true;
        public bool CustomFFmpeg = false;
        public int bitrate = 20000;
        public int crf = 10;
        public string crfPreset = "ultrafast";
        public bool ffmpegDebug = false;
        public string ffoption = "";

        public bool showNoteCount = false;
        public bool showNotesRendered = false;
        public int fontSize = 50;
        public string font = "Arial";

        public bool running = false;

        public bool playSound = true;
        public bool playbackEnabled = true;

        public bool realtimePlayback = true;

        public double liveFps = 0;

        public bool timeBasedNotes = false;

        public bool ignoreColorEvents = false;

        public long lastBGChangeTime = -1;
        public string BGImage = null;

        public event Action PauseToggled;
        public bool Paused
        {
            get => paused;
            set
            {
                paused = value;
                PauseToggled();
            }
        }
        // using threads
        public bool useFilterThreads = false;
        public int filterThreadsForRender = Environment.ProcessorCount;
        // encoder
        public string encoder = "libx264";
        // yuv
        public string yuvcode = "420p";
        // skip
        public int skip = 5000;
        // width, height
        public int preview_width = /*(int)(OpenTK.DisplayDevice.Default.Width / 1.5)*/1920;
        public int preview_height = /*(int)(OpenTK.DisplayDevice.Default.Width / 1.5) / 16 * 9*/1080;
        // max render memory
        public long maxRenderRAM = 8192;
        // enable memory limit (or not)
        public bool enableMemoryLimit = true;
        // auto disable kdmapi when rendering (in order to save memory)
        public bool autoDisableKDMAPIWhenRendering = true;
        // enable memory saving mode (or not)
        public bool enableMemorySavingMode = false;
        // full arg
        public bool useFullArguments = false;
        public string fullArgs = "";
        // collect memory by notes
        public bool collectMemoryByNotes = false;
        public long collectLimit = 1500000;
        // adjust memory collection automatically (or not?)
        public bool autoAdjustCollection = false;

        public bool disableInfoWriting = false;

        public bool useMultithreadToLoadMidi = true;

        public long renderedFrames = 0;

        public string ffMergeInfo = "";
    }
}
