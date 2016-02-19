﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CodeAnalysis.IL.Rules
{ 
    /// <summary>
    /// This class defines a range of execution conditions that identify various results
    /// in code, both for primary function of application and negative conditions
    /// </summary>
    public enum CryptoError : uint
    {
        ERROR_SUCCESS = 0,
        CERT_E_CHAINING = 0x800B010A, // An internal certificate chaining error has occurred.
        CERT_E_CN_NO_MATCH = 0x800B010F, // The certificate's CN name does not match the passed value.
        CERT_E_CRITICAL = 0x800B0105, // A certificate contains an unknown extension that is marked 'critical'.
        CERT_E_EXPIRED = 0x800B0101, // A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file.
        CERT_E_INVALID_NAME = 0x800B0114,  // The certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.
        CERT_E_INVALID_POLICY = 0x800B0113, // The certificate has invalid policy.
        CERT_E_ISSUERCHAINING = 0x800B0107, // A parent of a given certificate in fact did not issue that child certificate.
        CERT_E_MALFORMED = 0x800B0108, // A certificate is missing or has an empty value for an important field, such as a subject or issuer name.
        CERT_E_PATHLENCONST = 0x800B0104, // A path length constraint in the certification chain has been violated.
        CERT_E_PURPOSE = 0x800B0106, // A certificate being used for a purpose other than the ones specified by its CA.
        CERT_E_REVOCATION_FAILURE = 0x800B010E, // The revocation process could not continue - the certificate(s) could not be checked.
        CERT_E_REVOKED = 0x800B010C, // A certificate was explicitly revoked by its issuer.
        CERT_E_ROLE = 0x800B0103, // A certificate that can only be used as an end-entity is being used as a CA or visa versa.
        CERT_E_UNTRUSTEDCA = 0x800B0112, // A certification chain processed correctly, but one of the CA certificates is not trusted by the policy provider.
        CERT_E_UNTRUSTEDROOT = 0x800B0109, // A certificate chain processed correctly, but terminated in a root certificate which is not trusted by the trust provider.
        CERT_E_UNTRUSTEDTESTROOT = 0x800B010D, // The certification path terminates with the test root which is not trusted with the current policy settings.
        CERT_E_VALIDITYPERIODNESTING = 0x800B0102, // The validity periods of the certification chain do not nest correctly.
        CERT_E_WRONG_USAGE = 0x800B0110, // The certificate is not valid for the requested usage.
        CERTSRV_E_BAD_REQUESTSTATUS = 0x80094003, // The request's current status does not allow this operation.
        CERTSRV_E_BAD_REQUESTSUBJECT = 0x80094001, // The request subject name is invalid or too long.
        CERTSRV_E_ENCODING_LENGTH = 0x80094007, // The certificate contains an encoded length that is potentially incompatible with older enrollment software.
        CERTSRV_E_INVALID_CA_CERTIFICATE = 0x80094005, // The certification authority's certificate contains invalid data.
        CERTSRV_E_NO_CERT_TYPE = 0x80094801, // The request contains no certificate template information.
        CERTSRV_E_NO_REQUEST = 0x80094002, // The request does not exist.
        CERTSRV_E_PROPERTY_EMPTY = 0x80094004, // The requested property value is empty.
        CERTSRV_E_SERVER_SUSPENDED = 0x80094006, // Certificate service has been suspended for a database restore operation.
        CERTSRV_E_UNSUPPORTED_CERT_TYPE = 0x80094800, // The requested certificate template is not supported by this CA.
        CRYPT_E_ALREADY_DECRYPTED = 0x80091009, // The content of the cryptographic message has already been decrypted.
        CRYPT_E_ASN1_BADARGS = 0x80093109, // ASN1 bad arguments to function call.
        CRYPT_E_ASN1_BADPDU = 0x80093108, // ASN1 function not supported for this PDU.
        CRYPT_E_ASN1_BADREAL = 0x8009310A, // ASN1 bad real value.
        CRYPT_E_ASN1_BADTAG = 0x8009310B, // ASN1 bad tag value met.
        CRYPT_E_ASN1_CHOICE = 0x8009310C, // ASN1 bad choice value.
        CRYPT_E_ASN1_CONSTRAINT = 0x80093105, // ASN1 constraint violated.
        CRYPT_E_ASN1_CORRUPT = 0x80093103, // ASN1 corrupted data.
        CRYPT_E_ASN1_EOD = 0x80093102, // ASN1 unexpected end of data.
        CRYPT_E_ASN1_ERROR = 0x80093100, // ASN1 Certificate encode/decode error code base.
        CRYPT_E_ASN1_EXTENDED = 0x80093201, // ASN1 skipped unknown extension(s).
        CRYPT_E_ASN1_INTERNAL = 0x80093101, // ASN1 internal encode or decode error.
        CRYPT_E_ASN1_LARGE = 0x80093104, // ASN1 value too large.
        CRYPT_E_ASN1_MEMORY = 0x80093106, // ASN1 out of memory.
        CRYPT_E_ASN1_NOEOD = 0x80093202, // ASN1 end of data expected.
        CRYPT_E_ASN1_NYI = 0x80093134, // ASN1 not yet implemented.
        CRYPT_E_ASN1_OVERFLOW = 0x80093107, // ASN1 buffer overflow.
        CRYPT_E_ASN1_PDU_TYPE = 0x80093133, // ASN1 bad PDU type.
        CRYPT_E_ASN1_RULE = 0x8009310D, // ASN1 bad encoding rule.
        CRYPT_E_ASN1_UTF8 = 0x8009310E, // ASN1 bad unicode (UTF8).
        CRYPT_E_ATTRIBUTES_MISSING = 0x8009100F, // The cryptographic message does not contain all of the requested attributes.
        CRYPT_E_AUTH_ATTR_MISSING = 0x80091006, // The cryptographic message does not contain an expected authenticated attribute.
        CRYPT_E_BAD_ENCODE = 0x80092002, // An error occurred during encode or decode operation.
        CRYPT_E_BAD_LEN = 0x80092001, // The length specified for the output data was insufficient.
        CRYPT_E_BAD_MSG = 0x8009200D, // Not a cryptographic message or the cryptographic message is not formatted correctly.
        CRYPT_E_CONTROL_TYPE = 0x8009100C, // Invalid control type.
        CRYPT_E_DELETED_PREV = 0x80092008, // The previous certificate or CRL context was deleted.
        CRYPT_E_EXISTS = 0x80092005, // The object or property already exists.
        CRYPT_E_FILE_ERROR = 0x80092003, // An error occurred while reading or writing to a file.
        CRYPT_E_FILERESIZED = 0x80092025, // The Put operation can not continue.The file needs to be resized.However, there is already a signature present.A complete signing operation must be done.
        CRYPT_E_HASH_VALUE = 0x80091007, // The hash value is not correct.
        CRYPT_E_INVALID_IA5_STRING = 0x80092022, // The string contains a character not in the 7 bit ASCII character set.
        CRYPT_E_INVALID_INDEX = 0x80091008, // The index value is not valid.
        CRYPT_E_INVALID_MSG_TYPE = 0x80091004, // Invalid cryptographic message type.
        CRYPT_E_INVALID_NUMERIC_STRING = 0x80092020, // The string contains a non-numeric character.
        CRYPT_E_INVALID_PRINTABLE_STRING = 0x80092021, // The string contains a non-printable character.
        CRYPT_E_INVALID_X500_STRING = 0x80092023, // The string contains an invalid X500 name attribute key, oid, value or delimiter.
        CRYPT_E_ISSUER_SERIALNUMBER = 0x8009100D, // Invalid issuer and/or serial number.
        CRYPT_E_MISSING_PUBKEY_PARA = 0x8009202C, // The public key's algorithm parameters are missing.
        CRYPT_E_MSG_ERROR = 0x80091001, // An error occurred while performing an operation on a cryptographic message.
        CRYPT_E_NO_DECRYPT_CERT = 0x8009200C, // Cannot find the certificate and private key to use for decryption.
        CRYPT_E_NO_KEY_PROPERTY = 0x8009200B, // Cannot find the certificate and private key for decryption.
        CRYPT_E_NO_MATCH = 0x80092009, // Cannot find the requested object.
        CRYPT_E_NO_PROVIDER = 0x80092006, // No provider was specified for the store or object.
        CRYPT_E_NO_REVOCATION_CHECK = 0x80092012, // The revocation function was unable to check revocation for the certificate.
        CRYPT_E_NO_REVOCATION_DLL = 0x80092011, // No Dll or exported function was found to verify revocation.
        CRYPT_E_NO_SIGNER = 0x8009200E, // The signed cryptographic message does not have a signer for the specified signer index.
        CRYPT_E_NO_TRUSTED_SIGNER = 0x8009202B, // None of the signers of the cryptographic message or certificate trust list is trusted.
        CRYPT_E_NO_VERIFY_USAGE_CHECK = 0x80092028, // The called function was unable to do a usage check on the subject.
        CRYPT_E_NO_VERIFY_USAGE_DLL = 0x80092027, // No DLL or exported function was found to verify subject usage.
        CRYPT_E_NOT_CHAR_STRING = 0x80092024, // The dwValueType for the CERT_NAME_VALUE is not one of the character strings.Most likely it is either a CERT_RDN_ENCODED_BLOB or CERT_TDN_OCTED_STRING.
        CRYPT_E_NOT_DECRYPTED = 0x8009100A, // The content of the cryptographic message has not been decrypted yet.
        CRYPT_E_NOT_FOUND = 0x80092004, // Cannot find object or property.
        CRYPT_E_NOT_IN_CTL = 0x8009202A, // The subject was not found in a Certificate Trust List (CTL).
        CRYPT_E_NOT_IN_REVOCATION_DATABASE = 0x80092014, // The certificate is not in the revocation server's database.
        CRYPT_E_OID_FORMAT = 0x80091003, // The object identifier is poorly formatted.
        CRYPT_E_OSS_ERROR = 0x80093000, // OSS Certificate encode/decode error code base  
        CRYPT_E_PENDING_CLOSE = 0x8009200F, // Final closure is pending until additional frees or closes.
        CRYPT_E_RECIPIENT_NOT_FOUND = 0x8009100B, // The enveloped-data message does not contain the specified recipient.
        CRYPT_E_REVOCATION_OFFLINE = 0x80092013, // The revocation function was unable to check revocation because the revocation server was offline.
        CRYPT_E_REVOKED = 0x80092010, // The certificate is revoked.
        CRYPT_E_SECURITY_SETTINGS = 0x80092026, // The cryptographic operation failed due to a local security option setting.
        CRYPT_E_SELF_SIGNED = 0x80092007, // The specified certificate is self signed.
        CRYPT_E_SIGNER_NOT_FOUND = 0x8009100E, // Cannot find the original signer.
        CRYPT_E_STREAM_INSUFFICIENT_DATA = 0x80091011, // The streamed cryptographic message requires more data to complete the decode operation.
        CRYPT_E_STREAM_MSG_NOT_READY = 0x80091010, // The streamed cryptographic message is not ready to return data.
        CRYPT_E_UNEXPECTED_ENCODING = 0x80091005, // Unexpected cryptographic message encoding.
        CRYPT_E_UNEXPECTED_MSG_TYPE = 0x8009200A, // The certificate does not have a property that references a private key.
        CRYPT_E_UNKNOWN_ALGO = 0x80091002, // Unknown cryptographic algorithm.
        CRYPT_E_VERIFY_USAGE_OFFLINE = 0x80092029, // Since the server was offline, the called function was unable to complete the usage check.
        DIGSIG_E_CRYPTO = 0x800B0008, // Unspecified cryptographic failure.
        DIGSIG_E_DECODE = 0x800B0006, // Error due to problem in ASN.1 decoding process.
        DIGSIG_E_ENCODE = 0x800B0005, // Error due to problem in ASN.1 encoding process.
        DIGSIG_E_EXTENSIBILITY = 0x800B0007, // Reading / writing Extensions where Attributes are appropriate, and visa versa.
        MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = 0x80097008, // First table does not appear after header information.
        MSSIPOTF_E_BAD_MAGICNUMBER = 0x80097004, // The magic number in the head table is incorrect.
        MSSIPOTF_E_BAD_OFFSET_TABLE = 0x80097005, // The offset table has incorrect values.
        MSSIPOTF_E_BADVERSION = 0x80097015, // There is a bad version number in the file.
        MSSIPOTF_E_CANTGETOBJECT = 0x80097002, // Could not retrieve an object from the file.
        MSSIPOTF_E_CRYPT = 0x80097014, // A call to a CryptoAPI function failed.
        MSSIPOTF_E_DSIG_STRUCTURE = 0x80097016, // The structure of the DSIG table is incorrect.
        MSSIPOTF_E_FAILED_HINTS_CHECK = 0x80097011, // The file did not pass the hints check.
        MSSIPOTF_E_FAILED_POLICY = 0x80097010, // The signature does not have the correct attributes for the policy.
        MSSIPOTF_E_FILE = 0x80097013, // Failed on a file operation (open, map, read, write).
        MSSIPOTF_E_FILE_CHECKSUM = 0x8009700D, // The file checksum is incorrect.
        MSSIPOTF_E_FILETOOSMALL = 0x8009700B, // File is too small to contain the last table.
        MSSIPOTF_E_NOHEADTABLE = 0x80097003, // Could not find the head table in the file.
        MSSIPOTF_E_NOT_OPENTYPE = 0x80097012, // The file is not an OpenType file.
        MSSIPOTF_E_OUTOFMEMRANGE = 0x80097001, // Tried to reference a part of the file outside the proper range.
        MSSIPOTF_E_PCONST_CHECK = 0x80097017, // A check failed in a partially constant table.
        MSSIPOTF_E_STRUCTURE = 0x80097018, // Some kind of structural error.
        MSSIPOTF_E_TABLE_CHECKSUM = 0x8009700C, // A table checksum is incorrect.
        MSSIPOTF_E_TABLE_LONGWORD = 0x80097007, // A table does not start on a long word boundary.
        MSSIPOTF_E_TABLE_PADBYTES = 0x8009700A, // Too many pad bytes between tables or pad bytes are not 0.
        MSSIPOTF_E_TABLE_TAGORDER = 0x80097006, // Duplicate table tags or tags out of alphabetical order.
        MSSIPOTF_E_TABLES_OVERLAP = 0x80097009, // Two or more tables overlap.
        NTE_BAD_ALGID = 0x80090008, // Invalid algorithm specified.
        PERSIST_E_NOTSELFSIZING = 0x800B000B, // This object does not read and write self-sizing data.
        PERSIST_E_SIZEDEFINITE = 0x800B0009, // The size of the data could not be determined.
        PERSIST_E_SIZEINDEFINITE = 0x800B000A, // The size of the indefinite-sized data could not be determined.
        TRUST_E_ACTION_UNKNOWN = 0x800B0002, // The trust verification action specified is not supported by the specified trust provider.
        TRUST_E_BAD_DIGEST = 0x80096010, // The digital signature of the object did not verify.
        TRUST_E_BASIC_CONSTRAINTS = 0x80096019, // A certificate's basic constraint extension has not been observed.
        TRUST_E_CERT_SIGNATURE = 0x80096004, // The signature of the certificate can not be verified.
        TRUST_E_COUNTER_SIGNER = 0x80096003, // One of the counter signatures was invalid.
        TRUST_E_EXPLICIT_DISTRUST = 0x800B0111, // The certificate was explicitly marked as untrusted by the user.
        TRUST_E_FAIL = 0x800B010B, // Generic trust failure.
        TRUST_E_FINANCIAL_CRITERIA = 0x8009601E, // The certificate does not meet or contain the Authenticode financial extensions.
        TRUST_E_NO_SIGNER_CERT = 0x80096002, // The certificate for the signer of the message is invalid or not found.
        TRUST_E_NOSIGNATURE = 0x800B0100, // No signature was present in the subject.
        TRUST_E_PROVIDER_UNKNOWN = 0x800B0001, // Unknown trust provider.
        TRUST_E_SUBJECT_FORM_UNKNOWN = 0x800B0003, // The form specified for the subject is not one supported or known by the specified trust provider.
        TRUST_E_SUBJECT_NOT_TRUSTED = 0x800B0004, // The subject is not trusted for the specified action.
        TRUST_E_SYSTEM_ERROR = 0x80096001, // A system-level error occurred while verifying trust.
        TRUST_E_TIME_STAMP = 0x80096005, // The timestamp signature and/or certificate could not be verified or is malformed.
    }
}