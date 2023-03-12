

using var image = Image.Load(@"..\..\..\food.jpg");

image.Mutate(x => x.Resize(image.Width / 4, image.Height / 4));

await image.SaveAsWebpAsync(@"..\..\..\result.webp");
