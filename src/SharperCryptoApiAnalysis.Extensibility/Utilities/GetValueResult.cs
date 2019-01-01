﻿namespace SharperCryptoApiAnalysis.Extensibility.Utilities
{
    public enum GetValueResult
    {
        Success,
        Created,
        Missing,
        Corrupt,
        IncompatibleType,
        ObsoleteFormat,
        UnknownError
    }
}