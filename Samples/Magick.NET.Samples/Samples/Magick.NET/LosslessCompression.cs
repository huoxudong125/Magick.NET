﻿//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.IO;
using ImageMagick;

namespace RootNamespace.Samples.MagickNET
{
    public static class LosslessCompressionSamples
    {
        public static void MakeGooglePageSpeedInsightsHappy()
        {
            FileInfo snakewareLogo = new FileInfo(SampleFiles.OutputDirectory + "OptimizeTest.jpg");
            File.Copy(SampleFiles.SnakewareJpg, snakewareLogo.FullName, true);

            Console.WriteLine("Bytes before: " + snakewareLogo.Length);

            ImageOptimizer optimizer = new ImageOptimizer();
            optimizer.LosslessCompress(snakewareLogo);

            snakewareLogo.Refresh();
            Console.WriteLine("Bytes after:  " + snakewareLogo.Length);
        }
    }
}
