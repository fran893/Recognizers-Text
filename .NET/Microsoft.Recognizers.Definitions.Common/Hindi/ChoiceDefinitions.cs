//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Hindi\Hindi-Choice.yaml
//     - Language: Hindi
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Hindi
{
    using System;
    using System.Collections.Generic;

    public static class ChoiceDefinitions
    {
      public const string LangMarker = @"Hin";
      public const string TokenizerRegex = @"[^\w\d\u0900-\u097f]";
      public const string TrueRegex = @"\b(true|yes|yep|y|sure|ok|agree|बिलकुल|हाँ|हां|सहमत)\b|(\uD83D\uDC4D|\uD83D\uDC4C|\u0001f44c)";
      public const string FalseRegex = @"\b(false|nope|nop|no|not\s+ok|disagree)\b|((नहीं|ठीक\s+नहीं|असहमत)\b|(ना))|(\uD83D\uDC4E|\u270B|\uD83D\uDD90|\u0001F44E|\u0001F590)";
    }
}