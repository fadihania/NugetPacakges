

using var image = Image.Load(@"..\..\..\food.jpg");

image.Mutate(x =>
{
    x.Resize(image.Width / 4, image.Height / 4);
    x.Grayscale();
    x.Flip(FlipMode.Horizontal);
    x.Crop(new Rectangle
    {
        X = 100,
        Y = 0,
        Width = image.Width - 100,
        Height = image.Height
    });
});

await image.SaveAsJpegAsync(@"..\..\..\result.jpg");
