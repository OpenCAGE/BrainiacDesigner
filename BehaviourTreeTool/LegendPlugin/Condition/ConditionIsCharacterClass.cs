////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2009, Daniel Kollmann
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, are permitted
// provided that the following conditions are met:
//
// - Redistributions of source code must retain the above copyright notice, this list of conditions
//   and the following disclaimer.
//
// - Redistributions in binary form must reproduce the above copyright notice, this list of
//   conditions and the following disclaimer in the documentation and/or other materials provided
//   with the distribution.
//
// - Neither the name of Daniel Kollmann nor the names of its contributors may be used to endorse
//   or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
// IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY
// WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using Brainiac.Design.Nodes;
using Brainiac.Design.Attributes;
using LegendPlugin.Properties;

namespace LegendPlugin.Nodes
{
	public class ConditionIsCharacterClass : ConditionConnectors
	{
        //All parameters added

        protected CHARACTER_CLASS _cond;
        protected CharacterType _cond2;

        [DesignerEnum("Character class", "CharacterClass", "CategoryBasic", DesignerProperty.DisplayMode.Parameter, 0, DesignerProperty.DesignerFlags.NoFlags, null)]
        public CHARACTER_CLASS CharacterClass
        {
            get { return _cond; }
            set { _cond = value; }
        }

        [DesignerEnum("Character type", "CharacterType", "CategoryBasic", DesignerProperty.DisplayMode.Parameter, 0, DesignerProperty.DesignerFlags.NoFlags, null)]
        public CharacterType CharacterType
        {
            get { return _cond2; }
            set { _cond2 = value; }
        }

        public ConditionIsCharacterClass()
            : base("IsCharacterClass", "CHECK TO SEE IF OWNER AND/OR TARGET ARE A SPECIFIED CHARACTER CLASS.")
 
        {
        }

        protected override void CloneProperties(Node newnode)
        {
            base.CloneProperties(newnode);

            ConditionIsCharacterClass cond = (ConditionIsCharacterClass)newnode;
            cond._cond = _cond;
            cond._cond2 = _cond2;
        }
    }
}
