﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.QuickInfo;
using Microsoft.VisualStudio.Text;

namespace Microsoft.CodeAnalysis.Editor
{
    internal interface IQuickInfoPresenterSession : IIntelliSensePresenterSession
    {
        void PresentItem(ITrackingSpan triggerSpan, QuickInfoData item, bool trackMouse);
    }
}
