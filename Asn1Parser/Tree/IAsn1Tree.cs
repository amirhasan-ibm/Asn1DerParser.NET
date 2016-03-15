using SysadminsLV.Asn1Parser.CLRExtensions.Generics;
using System;

namespace SysadminsLV.Asn1Parser.Tree {
    /// <summary>
    /// Defines data source members in the ASN.1 tree class.
    /// </summary>
	public interface IAsn1TreeSource {
        /// <summary>
        /// Gets the byte array that holds ASN.1-encoded byte array.
        /// </summary>
        /// <remarks>Interface implementations shall not modify this member on its own.</remarks>
		ObservableList<Byte> RawData { get; }
	}
}