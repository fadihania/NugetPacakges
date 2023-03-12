using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

using var image = Image.Load(@"..\..\..\food.jpg");
image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
image.Save(@"..\..\..\result.jpg");
