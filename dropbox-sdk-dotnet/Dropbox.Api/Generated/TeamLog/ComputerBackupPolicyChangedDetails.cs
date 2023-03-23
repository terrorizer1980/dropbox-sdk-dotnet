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
    /// <para>Changed computer backup policy for team.</para>
    /// </summary>
    public class ComputerBackupPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ComputerBackupPolicyChangedDetails> Encoder = new ComputerBackupPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ComputerBackupPolicyChangedDetails> Decoder = new ComputerBackupPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ComputerBackupPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New computer backup policy.</param>
        /// <param name="previousValue">Previous computer backup policy.</param>
        public ComputerBackupPolicyChangedDetails(ComputerBackupPolicy newValue,
                                                  ComputerBackupPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ComputerBackupPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ComputerBackupPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>New computer backup policy.</para>
        /// </summary>
        public ComputerBackupPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous computer backup policy.</para>
        /// </summary>
        public ComputerBackupPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ComputerBackupPolicyChangedDetails" />.</para>
        /// </summary>
        private class ComputerBackupPolicyChangedDetailsEncoder : enc.StructEncoder<ComputerBackupPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ComputerBackupPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ComputerBackupPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ComputerBackupPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ComputerBackupPolicyChangedDetails" />.</para>
        /// </summary>
        private class ComputerBackupPolicyChangedDetailsDecoder : enc.StructDecoder<ComputerBackupPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ComputerBackupPolicyChangedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ComputerBackupPolicyChangedDetails Create()
            {
                return new ComputerBackupPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ComputerBackupPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ComputerBackupPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ComputerBackupPolicy.Decoder.Decode(reader);
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