//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System.Collections.Generic;
using System.Text;

namespace ImageMagick
{
    [System.CodeDom.Compiler.GeneratedCode("Magick.NET.FileGenerator", "")]
    public sealed partial class Drawables
    {
        /// <summary>
        /// Adds a new instance of the <see cref="DrawableAffine" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="scaleX">The X coordinate scaling element.</param>
        /// <param name="scaleY">The Y coordinate scaling element.</param>
        /// <param name="shearX">The X coordinate shearing element.</param>
        /// <param name="shearY">The Y coordinate shearing element.</param>
        /// <param name="translateX">The X coordinate of the translation element.</param>
        /// <param name="translateY">The Y coordinate of the translation element.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Affine(double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY)
        {
            _Drawables.Add(new DrawableAffine(scaleX, scaleY, shearX, shearY, translateX, translateY));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableAlpha" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Alpha(double x, double y, PaintMethod paintMethod)
        {
            _Drawables.Add(new DrawableAlpha(x, y, paintMethod));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableArc" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate of the bounding rectangle.</param>
        /// <param name="startY">The starting Y coordinate of thebounding rectangle.</param>
        /// <param name="endX">The ending X coordinate of the bounding rectangle.</param>
        /// <param name="endY">The ending Y coordinate of the bounding rectangle.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Arc(double startX, double startY, double endX, double endY, double startDegrees, double endDegrees)
        {
            _Drawables.Add(new DrawableArc(startX, startY, endX, endY, startDegrees, endDegrees));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableBezier" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Bezier(params PointD[] coordinates)
        {
            _Drawables.Add(new DrawableBezier(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableBezier" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Bezier(IEnumerable<PointD> coordinates)
        {
            _Drawables.Add(new DrawableBezier(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableBorderColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color of the border.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables BorderColor(MagickColor color)
        {
            _Drawables.Add(new DrawableBorderColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableCircle" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="perimeterX">The perimeter X coordinate.</param>
        /// <param name="perimeterY">The perimeter Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Circle(double originX, double originY, double perimeterX, double perimeterY)
        {
            _Drawables.Add(new DrawableCircle(originX, originY, perimeterX, perimeterY));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableClipPath" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables ClipPath(string clipPath)
        {
            _Drawables.Add(new DrawableClipPath(clipPath));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableClipRule" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables ClipRule(FillRule fillRule)
        {
            _Drawables.Add(new DrawableClipRule(fillRule));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableClipUnits" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="units">The clip path units.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables ClipUnits(ClipPathUnit units)
        {
            _Drawables.Add(new DrawableClipUnits(units));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="paintMethod">The paint method to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Color(double x, double y, PaintMethod paintMethod)
        {
            _Drawables.Add(new DrawableColor(x, y, paintMethod));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableComposite" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Composite(MagickGeometry offset, IMagickImage image)
        {
            _Drawables.Add(new DrawableComposite(offset, image));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableComposite" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Composite(double x, double y, IMagickImage image)
        {
            _Drawables.Add(new DrawableComposite(x, y, image));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableComposite" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The offset from origin.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Composite(MagickGeometry offset, CompositeOperator compose, IMagickImage image)
        {
            _Drawables.Add(new DrawableComposite(offset, compose, image));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableComposite" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="compose">The algorithm to use.</param>
        /// <param name="image">The image to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Composite(double x, double y, CompositeOperator compose, IMagickImage image)
        {
            _Drawables.Add(new DrawableComposite(x, y, compose, image));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableDensity" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="density">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Density(double density)
        {
            _Drawables.Add(new DrawableDensity(density));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableDensity" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="pointDensity">The vertical and horizontal resolution.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Density(PointD pointDensity)
        {
            _Drawables.Add(new DrawableDensity(pointDensity));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableEllipse" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="originX">The origin X coordinate.</param>
        /// <param name="originY">The origin Y coordinate.</param>
        /// <param name="radiusX">The X radius.</param>
        /// <param name="radiusY">The Y radius.</param>
        /// <param name="startDegrees">The starting degrees of rotation.</param>
        /// <param name="endDegrees">The ending degrees of rotation.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Ellipse(double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees)
        {
            _Drawables.Add(new DrawableEllipse(originX, originY, radiusX, radiusY, startDegrees, endDegrees));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFillColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FillColor(MagickColor color)
        {
            _Drawables.Add(new DrawableFillColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFillOpacity" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FillOpacity(Percentage opacity)
        {
            _Drawables.Add(new DrawableFillOpacity(opacity));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFillPatternUrl" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FillPatternUrl(string url)
        {
            _Drawables.Add(new DrawableFillPatternUrl(url));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFillRule" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="fillRule">The rule to use when filling drawn objects.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FillRule(FillRule fillRule)
        {
            _Drawables.Add(new DrawableFillRule(fillRule));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFont" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Font(string family)
        {
            _Drawables.Add(new DrawableFont(family));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFont" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="family">The font family or the full path to the font file.</param>
        /// <param name="style">The style of the font.</param>
        /// <param name="weight">The weight of the font.</param>
        /// <param name="stretch">The font stretching type.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Font(string family, FontStyleType style, FontWeight weight, FontStretch stretch)
        {
            _Drawables.Add(new DrawableFont(family, style, weight, stretch));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableFontPointSize" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="pointSize">The point size.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables FontPointSize(double pointSize)
        {
            _Drawables.Add(new DrawableFontPointSize(pointSize));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableGravity" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="gravity">The gravity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Gravity(Gravity gravity)
        {
            _Drawables.Add(new DrawableGravity(gravity));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableLine" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="startX">The starting X coordinate.</param>
        /// <param name="startY">The starting Y coordinate.</param>
        /// <param name="endX">The ending X coordinate.</param>
        /// <param name="endY">The ending Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Line(double startX, double startY, double endX, double endY)
        {
            _Drawables.Add(new DrawableLine(startX, startY, endX, endY));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePath" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Path(params IPath[] paths)
        {
            _Drawables.Add(new DrawablePath(paths));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePath" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="paths">The paths to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Path(IEnumerable<IPath> paths)
        {
            _Drawables.Add(new DrawablePath(paths));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePoint" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Point(double x, double y)
        {
            _Drawables.Add(new DrawablePoint(x, y));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePolygon" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Polygon(params PointD[] coordinates)
        {
            _Drawables.Add(new DrawablePolygon(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePolygon" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Polygon(IEnumerable<PointD> coordinates)
        {
            _Drawables.Add(new DrawablePolygon(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePolyline" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Polyline(params PointD[] coordinates)
        {
            _Drawables.Add(new DrawablePolyline(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePolyline" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Polyline(IEnumerable<PointD> coordinates)
        {
            _Drawables.Add(new DrawablePolyline(coordinates));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePopClipPath" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PopClipPath()
        {
            _Drawables.Add(new DrawablePopClipPath());
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePopGraphicContext" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PopGraphicContext()
        {
            _Drawables.Add(new DrawablePopGraphicContext());
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePopPattern" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PopPattern()
        {
            _Drawables.Add(new DrawablePopPattern());
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePushClipPath" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="clipPath">The ID of the clip path.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PushClipPath(string clipPath)
        {
            _Drawables.Add(new DrawablePushClipPath(clipPath));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePushGraphicContext" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PushGraphicContext()
        {
            _Drawables.Add(new DrawablePushGraphicContext());
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawablePushPattern" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="id">The ID of the pattern.</param>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables PushPattern(string id, double x, double y, double width, double height)
        {
            _Drawables.Add(new DrawablePushPattern(id, x, y, width, height));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableRectangle" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Rectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
        {
            _Drawables.Add(new DrawableRectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableRotation" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Rotation(double angle)
        {
            _Drawables.Add(new DrawableRotation(angle));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableRoundRectangle" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <param name="cornerWidth">The corner width.</param>
        /// <param name="cornerHeight">The corner height.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables RoundRectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY, double cornerWidth, double cornerHeight)
        {
            _Drawables.Add(new DrawableRoundRectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY, cornerWidth, cornerHeight));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableScaling" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">Horizontal scale factor.</param>
        /// <param name="y">Vertical scale factor.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Scaling(double x, double y)
        {
            _Drawables.Add(new DrawableScaling(x, y));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableSkewX" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables SkewX(double angle)
        {
            _Drawables.Add(new DrawableSkewX(angle));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableSkewY" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables SkewY(double angle)
        {
            _Drawables.Add(new DrawableSkewY(angle));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeAntialias" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="isEnabled">True if stroke antialiasing is enabled otherwise false.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeAntialias(bool isEnabled)
        {
            _Drawables.Add(new DrawableStrokeAntialias(isEnabled));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeColor(MagickColor color)
        {
            _Drawables.Add(new DrawableStrokeColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeDashArray" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="dash">An array containing the dash information.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeDashArray(params double[] dash)
        {
            _Drawables.Add(new DrawableStrokeDashArray(dash));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeDashOffset" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="offset">The dash offset.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeDashOffset(double offset)
        {
            _Drawables.Add(new DrawableStrokeDashOffset(offset));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeLineCap" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="lineCap">The line cap.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeLineCap(LineCap lineCap)
        {
            _Drawables.Add(new DrawableStrokeLineCap(lineCap));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeLineJoin" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="lineJoin">The line join.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeLineJoin(LineJoin lineJoin)
        {
            _Drawables.Add(new DrawableStrokeLineJoin(lineJoin));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeMiterLimit" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="miterlimit">The miter limit.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeMiterLimit(int miterlimit)
        {
            _Drawables.Add(new DrawableStrokeMiterLimit(miterlimit));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeOpacity" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="opacity">The opacity.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeOpacity(Percentage opacity)
        {
            _Drawables.Add(new DrawableStrokeOpacity(opacity));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokePatternUrl" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokePatternUrl(string url)
        {
            _Drawables.Add(new DrawableStrokePatternUrl(url));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableStrokeWidth" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables StrokeWidth(double width)
        {
            _Drawables.Add(new DrawableStrokeWidth(width));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableText" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="value">The text to draw.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Text(double x, double y, string value)
        {
            _Drawables.Add(new DrawableText(x, y, value));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextAlignment" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="alignment">Text alignment.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextAlignment(TextAlignment alignment)
        {
            _Drawables.Add(new DrawableTextAlignment(alignment));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextAntialias" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="isEnabled">True if text antialiasing is enabled otherwise false.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextAntialias(bool isEnabled)
        {
            _Drawables.Add(new DrawableTextAntialias(isEnabled));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextDecoration" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="decoration">The text decoration.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextDecoration(TextDecoration decoration)
        {
            _Drawables.Add(new DrawableTextDecoration(decoration));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextDirection" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="direction">Direction to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextDirection(TextDirection direction)
        {
            _Drawables.Add(new DrawableTextDirection(direction));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextEncoding" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="encoding">Encoding to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextEncoding(Encoding encoding)
        {
            _Drawables.Add(new DrawableTextEncoding(encoding));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextInterlineSpacing" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextInterlineSpacing(double spacing)
        {
            _Drawables.Add(new DrawableTextInterlineSpacing(spacing));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextInterwordSpacing" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="spacing">Spacing to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextInterwordSpacing(double spacing)
        {
            _Drawables.Add(new DrawableTextInterwordSpacing(spacing));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextKerning" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="kerning">Kerning to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextKerning(double kerning)
        {
            _Drawables.Add(new DrawableTextKerning(kerning));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTextUnderColor" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="color">The color to use.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables TextUnderColor(MagickColor color)
        {
            _Drawables.Add(new DrawableTextUnderColor(color));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableTranslation" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Translation(double x, double y)
        {
            _Drawables.Add(new DrawableTranslation(x, y));
            return this;
        }

        /// <summary>
        /// Adds a new instance of the <see cref="DrawableViewbox" /> class to the <see cref="Drawables" />.
        /// </summary>
        /// <param name="upperLeftX">The upper left X coordinate.</param>
        /// <param name="upperLeftY">The upper left Y coordinate.</param>
        /// <param name="lowerRightX">The lower right X coordinate.</param>
        /// <param name="lowerRightY">The lower right Y coordinate.</param>
        /// <returns>The <see cref="Drawables" /> instance.</returns>
        public Drawables Viewbox(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
        {
            _Drawables.Add(new DrawableViewbox(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
            return this;
        }

    }
}
