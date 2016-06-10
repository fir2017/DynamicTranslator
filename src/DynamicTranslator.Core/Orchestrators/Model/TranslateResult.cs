﻿using System;
using System.Runtime.Serialization;

namespace DynamicTranslator.Core.Orchestrators.Model
{
    #region using

    

    #endregion

    [Serializable]
    public class TranslateResult
    {
        public TranslateResult() : this(true, new Maybe<string>()) {}

        public TranslateResult(bool isSucess, Maybe<string> resultMessage)
        {
            IsSucess = isSucess;
            ResultMessage = resultMessage;
        }

        [DataMember]
        public bool IsSucess { get; set; }

        [DataMember]
        public Maybe<string> ResultMessage { get; set; }
    }
}