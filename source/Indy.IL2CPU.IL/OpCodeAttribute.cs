﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Indy.IL2CPU.IL {
	[AttributeUsage(AttributeTargets.Class, Inherited=true, AllowMultiple=false)]
	public class OpCodeAttribute: Attribute {
		public readonly Code OpCode;
		public readonly bool IsMetallic = true;

        public OpCodeAttribute(Code aOpCode) {
			OpCode = aOpCode;
		}
		public OpCodeAttribute(Code aOpCode, bool aIsMetallic):this(aOpCode) {
			IsMetallic = aIsMetallic;
		}
	}
}