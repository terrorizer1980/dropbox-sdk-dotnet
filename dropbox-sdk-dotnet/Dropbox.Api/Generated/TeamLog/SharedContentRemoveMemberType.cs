// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The shared content remove member type object</para>
    /// </summary>
    public class SharedContentRemoveMemberType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRemoveMemberType> Encoder = new SharedContentRemoveMemberTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRemoveMemberType> Decoder = new SharedContentRemoveMemberTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentRemoveMemberType"
        /// /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SharedContentRemoveMemberType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentRemoveMemberType"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRemoveMemberType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the shared content remove member type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRemoveMemberType" />.</para>
        /// </summary>
        private class SharedContentRemoveMemberTypeEncoder : enc.StructEncoder<SharedContentRemoveMemberType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRemoveMemberType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRemoveMemberType" />.</para>
        /// </summary>
        private class SharedContentRemoveMemberTypeDecoder : enc.StructDecoder<SharedContentRemoveMemberType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentRemoveMemberType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRemoveMemberType Create()
            {
                return new SharedContentRemoveMemberType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRemoveMemberType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}