using System;
using Carbon.Components;
using static Carbon.Components.CUI;
using UnityEngine;
using UnityEngine.UI;
using Oxide.Game.Rust.Cui;

namespace Carbon.Components
{
    using static Carbon.Components.CUIUtils;

    internal static class CUIUtils
    {
        public static bool TryParseTwoSpaceSeparatedFloats(string input, out float value1, out float value2)
        {
            var values = input.Split(' ');
            if (values.Length == 2 && float.TryParse(values[0], out value1) && float.TryParse(values[1], out value2))
            {
                return true;
            }

            value1 = value2 = 0f;
            return false;
        }
    }
    public class CUITransform
    {
        public float xMin = 0f;
        public float xMax = 1f;
        public float yMin = 0f;
        public float yMax = 1f;
        public float OxMin = 0f;
        public float OxMax = 0f;
        public float OyMin = 0f;
        public float OyMax = 0f;

        public string AnchorMin
        {
            get { return $"{xMin.ToString()} {yMin.ToString()}"; }
            set { TryParseTwoSpaceSeparatedFloats(value, out xMin, out yMin); }
        }

        public string AnchorMax
        {
            get { return $"{xMax.ToString()} {yMax.ToString()}"; }
            set { TryParseTwoSpaceSeparatedFloats(value, out xMax, out yMax); }
        }

        public string OffsetMin
        {
            get { return $"{OxMin.ToString()} {OyMin.ToString()}"; }
            set { TryParseTwoSpaceSeparatedFloats(value, out OxMin, out OyMin); }
        }

        public string OffsetMax
        {
            get { return $"{OxMax.ToString()} {OyMax.ToString()}"; }
            set { TryParseTwoSpaceSeparatedFloats(value, out OxMax, out OyMax); }
        }
    }

    public static class CUIExtensions
    {
        public static Pair<string, CuiElement> CreatePanel(this CUI cui, CuiElementContainer container, string parent, string color, string material = null, bool blur = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false, CUITransform transform = null)
        {
            transform ??= new CUITransform();
            return cui.CreatePanel(container, parent, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, blur, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateText(this CUI cui, CuiElementContainer container, string parent, string color, string text, int size, CUITransform transform = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, VerticalWrapMode verticalOverflow = VerticalWrapMode.Overflow, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateText(container, parent, color, text, size, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, align, font, verticalOverflow, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement, CuiElement> CreateButton(this CUI cui, CuiElementContainer container, string parent, string color, string textColor, string text, int size, string material = null, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateButton(container, parent, color, textColor, text, size, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement, CuiElement> CreateProtectedButton(this CUI cui, CuiElementContainer container, string parent, string color, string textColor, string text, int size, string material = null, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateProtectedButton(container, parent, color, textColor, text, size, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateInputField(this CUI cui, CuiElementContainer container, string parent, string color, string text, int size, int characterLimit, bool readOnly, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, InputField.LineType lineType = InputField.LineType.SingleLine, bool autoFocus = false, bool hudMenuInput = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            // return cui.CreateInputField(container, parent, color, text, size, characterLimit, readOnly, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, lineType, autoFocus, hudMenuInput, fadeIn, fadeOut, needsCursor, needsKeyboard, id, destroyUi, update);
            return cui.CreateInputField(container, parent, color, text, size, characterLimit, readOnly, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, autoFocus, hudMenuInput, lineType, fadeIn, fadeOut, needsCursor, needsKeyboard, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateProtectedInputField(this CUI cui, CuiElementContainer container, string parent, string color, string text, int size, int characterLimit, bool readOnly, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, InputField.LineType lineType = InputField.LineType.SingleLine, bool autoFocus = false, bool hudMenuInput = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateProtectedInputField(container, parent, color, text, size, characterLimit, readOnly, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, autoFocus, hudMenuInput, lineType, fadeIn, fadeOut, needsCursor, needsKeyboard, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateImage(this CUI cui, CuiElementContainer container, string parent, uint png, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateImage(container, parent, png, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateImage(this CUI cui, CuiElementContainer container, string parent, string url, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateImage(container, parent, url, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateImage(this CUI cui, CuiElementContainer container, string parent, string url, float scale, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateImage(container, parent, url, scale, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateSimpleImage(this CUI cui, CuiElementContainer container, string parent, string png, string sprite, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateSimpleImage(container, parent, png, sprite, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateSprite(this CUI cui, CuiElementContainer container, string parent, string sprite, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateSprite(container, parent, sprite, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateItemImage(this CUI cui, CuiElementContainer container, string parent, int itemID, ulong skinID, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateItemImage(container, parent, itemID, skinID, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateQRCodeImage(this CUI cui, CuiElementContainer container, string parent, string text, string brandUrl, string brandColor, string brandBgColor, int pixels, bool transparent, bool quietZones, string color, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateQRCodeImage(container, parent, text, brandUrl, brandColor, brandBgColor, pixels, transparent, quietZones, color, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }


        public static Pair<string, CuiElement> CreateClientImage(this CUI cui, CuiElementContainer container, string parent, string url, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateClientImage(container, parent, url, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, id, destroyUi, update);
        }

        public static Pair<string, CuiElement> CreateCountdown(this CUI cui, CuiElementContainer container, string parent, int startTime, int endTime, int step, string command, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateCountdown(container, parent, startTime, endTime, step, command, fadeIn, fadeOut, id, destroyUi, update);

        }

        // public static Pair<string, CuiElement> CreateScrollView(this CUI cui, CuiElementContainer container, string parent, bool vertical, bool horizontal, ScrollRect.MovementType movementType, float elasticity, bool inertia, float decelerationRate, float scrollSensitivity, string maskSoftness, CUITransform transform = null, out CuiRectTransform contentTransformComponent, out CuiScrollbar horizontalScrollBar, out CuiScrollbar verticalScrollBar, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string id = null, string destroyUi = null, bool update = false)
        public static Pair<string, CuiElement> CreateScrollView(this CUI cui, CuiElementContainer container, string parent, bool vertical, bool horizontal, ScrollRect.MovementType movementType, float elasticity, bool inertia, float decelerationRate, float scrollSensitivity, string maskSoftness, out CuiRectTransform contentTransformComponent, out CuiScrollbar horizontalScrollBar, out CuiScrollbar verticalScrollBar, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string id = null, string destroyUi = null, bool update = false)
        {
            transform ??= new CUITransform();
            return cui.CreateScrollView(container, parent, vertical, horizontal, movementType, elasticity, inertia, decelerationRate, scrollSensitivity, maskSoftness, out contentTransformComponent, out horizontalScrollBar, out verticalScrollBar, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, id, destroyUi, update);
        }

        // Update methods
        public static Pair<string, CuiElement> UpdatePanel(this CUI cui, string id, string color, string material = null, CUITransform transform = null, bool blur = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdatePanel(id, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, blur, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateText(this CUI cui, string id, string color, string text, int size, CUITransform transform = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, VerticalWrapMode verticalOverflow = VerticalWrapMode.Overflow, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateText(id, color, text, size, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, align, font, verticalOverflow, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement, CuiElement> UpdateButton(this CUI cui, string id, string color, string textColor, string text, int size, string material = null, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateButton(id, color, textColor, text, size, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement, CuiElement> UpdateProtectedButton(this CUI cui, string id, string color, string textColor, string text, int size, string material = null, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateProtectedButton(id, color, textColor, text, size, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateInputField(this CUI cui, string id, string color, string text, int size, int characterLimit, bool readOnly, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, InputField.LineType lineType = InputField.LineType.SingleLine, bool autoFocus = false, bool hudMenuInput = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateInputField(id, color, text, size, characterLimit, readOnly, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, autoFocus, hudMenuInput, lineType, fadeIn, fadeOut, needsCursor, needsKeyboard, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateProtectedInputField(this CUI cui, string id, string color, string text, int size, int characterLimit, bool readOnly, CUITransform transform = null, string command = null, TextAnchor align = TextAnchor.MiddleCenter, Handler.FontTypes font = Handler.FontTypes.RobotoCondensedRegular, InputField.LineType lineType = InputField.LineType.SingleLine, bool autoFocus = false, bool hudMenuInput = false, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateProtectedInputField(id, color, text, size, characterLimit, readOnly, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, command, align, font, autoFocus, hudMenuInput, lineType, fadeIn, fadeOut, needsCursor, needsKeyboard, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateImage(this CUI cui, string id, uint png, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateImage(id, png, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateImage(this CUI cui, string id, string url, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateImage(id, url, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateSimpleImage(this CUI cui, string id, string png, string sprite, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateSimpleImage(id, png, sprite, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateSprite(this CUI cui, string id, string sprite, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateSprite(id, sprite, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateItemImage(this CUI cui, string id, int itemID, ulong skinID, string color, string material = null, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateItemImage(id, itemID, skinID, color, material, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

        public static Pair<string, CuiElement> UpdateQRCodeImage(this CUI cui, string id, string text, string brandUrl, string brandColor, string brandBgColor, int pixels, bool transparent, bool quietZones, string color, CUITransform transform = null, float fadeIn = 0f, float fadeOut = 0f, bool needsCursor = false, bool needsKeyboard = false, string outlineColor = null, string outlineDistance = null, bool outlineUseGraphicAlpha = false, string destroyUi = null)
        {
            transform ??= new CUITransform();
            return cui.UpdateQRCodeImage(id, text, brandUrl, brandColor, brandBgColor, pixels, transparent, quietZones, color, transform.xMin, transform.xMax, transform.yMin, transform.yMax, transform.OxMin, transform.OxMax, transform.OyMin, transform.OyMax, fadeIn, fadeOut, needsCursor, needsKeyboard, outlineColor, outlineDistance, outlineUseGraphicAlpha, destroyUi);
        }

    }

}