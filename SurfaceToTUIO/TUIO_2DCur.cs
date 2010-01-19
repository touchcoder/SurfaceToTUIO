/***************************************************************************************
*  Author: 	Toni Schmidt
*  Mail:	toni.schmidt@uni-konstanz.de
*  TUIO 1.1 implementation: Martin Kaltenbrunner <martin@tuio.org>
*
*		Project Squidy, http://www.squidy-lib.de
*		Human-Computer Interaction Group
*		University of Konstanz, Germany
*		http://hci.uni-konstanz.de
*		http://sourceforge.net/projects/squidy-lib/
*
*  Copyright © 2009, Human-Computer Interaction Group, University of Konstanz, Germany
*  
*  This file is part of SurfaceToTUIO.
*
*  SurfaceToTUIO is free software: you can redistribute it and/or modify
*  it under the terms of the GNU Lesser General Public License as published by
*  the Free Software Foundation, either version 3 of the License, or
*  (at your option) any later version.
*
*  SurfaceToTUIO is distributed in the hope that it will be useful,
*  but WITHOUT ANY WARRANTY; without even the implied warranty of
*  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*  GNU Lesser General Public License for more details.
*
*  You should have received a copy of the GNU Lesser General Public License
*  along with SurfaceToTUIO.  If not, see <http://www.gnu.org/licenses/>.
*
***************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Surface.Core;
using OSC.NET;

namespace SurfaceToTUIO
{
    class TUIO_2DCur
    {
        public static OSCMessage sourceMessage()
        {
            OSCMessage message = new OSCMessage("/tuio/2Dcur");
            message.Append("source");
            message.Append("surface@127.0.0.1");
            return message;
        }
        public static OSCMessage aliveMessage(ReadOnlyContactCollection contacts)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dcur");
            message.Append("alive");
            for (int i = 0; i < contacts.Count; i++)
            {
                message.Append(contacts[i].Id);
            }
            return message;
        }
        public static OSCMessage aliveMessage(List<Contact> contacts)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dcur");
            message.Append("alive");
            for (int i = 0; i < contacts.Count; i++)
            {
                message.Append(contacts[i].Id);
            }
            return message;
        }
        public static OSCMessage frameMessage(int frame)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dcur");
            message.Append("fseq");
            message.Append(frame);
            return message;
        }

        public static OSCMessage setMessage(int s, float x, float y, float xVec, float yVec, float m)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dcur");
            message.Append("set");
            message.Append(s);
            message.Append(x);
            message.Append(y);
            message.Append(xVec);
            message.Append(yVec);
            message.Append(m);
            return message;
        }
    }
}
