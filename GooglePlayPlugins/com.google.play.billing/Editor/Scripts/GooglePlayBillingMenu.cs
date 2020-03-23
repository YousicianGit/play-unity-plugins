// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Android.AppBundle.Editor.Internal;
using UnityEditor;
using UnityEngine;

namespace Google.Play.Billing.Editor
{
    /// <summary>
    /// Provides "Play Billing" menu items for the Unity Editor.
    /// </summary>
    public static class GooglePlayBillingMenu
    {
        private const string PlayBilling = GoogleEditorMenu.MainMenuName + "/Play Billing/";

        private const int AboveLine = GoogleEditorMenu.PlayBillingPriority;
        private const int BelowLine = GoogleEditorMenu.PlayBillingPriority + GoogleEditorMenu.SeparatorSize;

        [MenuItem(PlayBilling + GoogleEditorMenu.BuildSettings, false, AboveLine)]
        private static void OpenBuildSettings()
        {
            GooglePlayBillingBuildSettings.ShowWindow();
        }

        [MenuItem(PlayBilling + GoogleEditorMenu.ViewDocumentation, false, BelowLine)]
        private static void ViewDocumentation()
        {
            Application.OpenURL("https://developer.android.com/google/play/billing/unity");
        }

        [MenuItem(PlayBilling + GoogleEditorMenu.ViewLicense, false, BelowLine + 1)]
        private static void ViewLicense()
        {
            // The guid is for GooglePlayPlugins/com.google.play.billing/LICENSE.md
            GoogleEditorMenu.OpenFileByGuid("ff930df64f4294487b3b89d15863363c");
        }

        [MenuItem(PlayBilling + GoogleEditorMenu.FileBug, false, BelowLine + 2)]
        private static void ViewPlayPluginsIssuesPage()
        {
            GoogleEditorMenu.ViewPlayPluginsIssuesPage();
        }
    }
}