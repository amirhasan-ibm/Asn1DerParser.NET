using System;
using System.IO;

namespace SysadminsLV.Asn1Parser.Universal {
    /// <summary>
    /// Represents an ASN.1 <strong>OCTET_STRING</strong> data type.
    /// </summary>
    public sealed class Asn1OctetString : UniversalTagBase {
        const Asn1Type TYPE = Asn1Type.OCTET_STRING;
        const Byte     TAG  = (Byte)TYPE;

        /// <summary>
        /// Initializes a new instance of the <strong>Asn1NumericString</strong> class from an <see cref="Asn1Reader"/>
        /// object.
        /// </summary>
        /// <param name="asn">Existing <see cref="Asn1Reader"/> object.</param>
        /// <exception cref="Asn1InvalidTagException">
        /// Current position in the <strong>ASN.1</strong> object is not <strong>NumericString</strong> data type.
        /// </exception>
        /// <exception cref="InvalidDataException">
        /// Input data contains invalid NumericString character.
        /// </exception>
        public Asn1OctetString(Asn1Reader asn) : base(asn) {
            if (asn.Tag != TAG) {
                throw new Asn1InvalidTagException(String.Format(InvalidType, TYPE.ToString()));
            }
            m_decode(asn);
        }
        /// <summary>
        /// Initializes a new instance of <strong>Asn1NumericString</strong> from a ASN.1-encoded byte array.
        /// </summary>
        /// <param name="rawData">ASN.1-encoded byte array.</param>
        /// <exception cref="Asn1InvalidTagException">
        /// <strong>rawData</strong> is not <strong>NumericString</strong> data type.
        /// </exception>
        /// <exception cref="InvalidDataException">
        /// Input data contains invalid NumericString character.
        /// </exception>
        public Asn1OctetString(Byte[] rawData) : this(new Asn1Reader(rawData)) { }

        /// <summary>
        /// Gets value associated with the current object.
        /// </summary>
        public Byte[] Value { get; private set; }

        void m_encode(String inputString) {
            //if (inputString.Any(c => (c < 48 || c > 57) && c != 32)) {
            //    throw new InvalidDataException(String.Format(InvalidType, TYPE.ToString()));
            //}
            //Value = inputString;
            //Initialize(new Asn1Reader(Asn1Utils.Encode(Encoding.ASCII.GetBytes(inputString), TAG)));
        }
        void m_decode(Asn1Reader asn) {
            //if (asn.GetPayload().Any(b => (b < 48 || b > 57) && b != 32)) {
            //    throw new InvalidDataException(String.Format(InvalidType, TYPE.ToString()));
            //}
            //Value = Encoding.ASCII.GetString(asn.GetPayload());
        }
    }
}
