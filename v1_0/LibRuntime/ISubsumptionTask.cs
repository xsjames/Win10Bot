﻿/*
 * Copyright (c) 2016..., Sergei Grichine   http://trackroamer.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *    
 * this is a no-warranty no-liability permissive license - you do not have to publish your changes,
 * although doing so, donating and contributing is always appreciated
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace slg.LibRuntime
{
    public interface ISubsumptionTask
    {
        string name { get; set; }

        /// <summary>
        /// behaviors can subscribe to control device events:
        /// this.controlDeviceEvent += new EventHandler<ControlDeviceEventArgs>(Behavior_controlDeviceEvent);
        /// </summary>
        event EventHandler<ControlDeviceEventArgs> controlDeviceEvent;

        /// <summary>
        /// called by TaskDispatcher when its  ControlDeviceCommand(string command)  is called.
        /// </summary>
        /// <param name="e"></param>
        void OnControlDeviceCommand(ControlDeviceEventArgs e);

        IEnumerator<ISubsumptionTask> Execute();

        void Close();
    }
}
