﻿/*
 * Copyright (c) 2010 - 2019, Stardog Union. <http://www.stardog.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using example;
using Semiodesk.Trinity;
using System;

namespace TrinityConsoleSample.ObjectModels
{
    /// <summary>
    /// A person or a group of people who participated in the creation of song as a composer or a lyricist.
    /// </summary>
    [RdfClass(MUSIC.Songwriter)]
    public class Songwriter : Person
    {
        #region Constructors

        public Songwriter(Uri uri) : base(uri) { }

        #endregion
    }
}