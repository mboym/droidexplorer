﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DroidExplorer.Core.Exceptions {
	public class CommandAbortingException : Exception {
		/// <summary>
		/// Initializes a new instance of the <see cref="CommandAbortingException"/> class.
		/// </summary>
		public CommandAbortingException ( )
			: base ( "Permission to access the specified resource was denied." ) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CommandAbortingException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		public CommandAbortingException ( String message )
			: base ( message ) {

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CommandAbortingException"/> class.
		/// </summary>
		/// <param name="serializationInfo">The serialization info.</param>
		/// <param name="context">The context.</param>
		public CommandAbortingException ( SerializationInfo serializationInfo, StreamingContext context )
			: base ( serializationInfo, context ) {

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CommandAbortingException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		public CommandAbortingException ( String message, Exception innerException )
			: base ( message, innerException ) {

		}
	}
}
