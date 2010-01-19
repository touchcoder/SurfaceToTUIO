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
using System.Collections.Specialized;

namespace SurfaceToTUIO
{
    class TUIO_2DObj
    {

        public static OSCMessage sourceMessage()
        {
            StringCollection localIP = Helper.getLocalIP();
            OSCMessage message = new OSCMessage("/tuio/2Dobj");
            message.Append("source");
            message.Append("surface@" + localIP[3]);
            return message;
        }
        public static OSCMessage aliveMessage(ReadOnlyContactCollection contacts)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dobj");
            message.Append("alive");
            for (int i = 0; i < contacts.Count; i++)
            {
                message.Append(contacts[i].Id);
            }
            return message;
        }
        public static OSCMessage aliveMessage(List<Contact> contacts)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dobj");
            message.Append("alive");
            for (int i = 0; i < contacts.Count; i++)
            {
                message.Append(contacts[i].Id);
            }
            return message;
        }
        public static OSCMessage frameMessage(int frame)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dobj");
            message.Append("fseq");
            message.Append(frame);
            return message;
        }

        public static OSCMessage setMessage(int s, int i, float x, float y, float a, float xVec, float yVec, float A, float m, float r)
        {
            OSCMessage message = new OSCMessage("/tuio/2Dobj");
            message.Append("set");
            message.Append(s);
            message.Append(i);
            message.Append(x);
            message.Append(y);
            message.Append(a);
            message.Append(xVec);
            message.Append(yVec);
            message.Append(A);
            message.Append(m);
            message.Append(r);
            return message;
        }
    }
}
