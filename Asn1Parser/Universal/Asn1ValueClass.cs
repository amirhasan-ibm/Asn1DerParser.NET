using System;

namespace SysadminsLV.Asn1Parser.Universal {
    public abstract class Asn1ValueClass<T> : UniversalTagBase {
        protected Asn1ValueClass() { }
        protected Asn1ValueClass(Asn1Reader asn) : base(asn) { }
        protected Asn1ValueClass(Byte[] rawData) : base(rawData) { }

        /// <summary>
        /// Gets value associated with the current object.
        /// </summary>
        public T Value { get; protected set; }
    }
}
