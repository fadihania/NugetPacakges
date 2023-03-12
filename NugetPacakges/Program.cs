

using var image = Image.Load(@"..\..\..\food.jpg");

image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));

await image.SaveAsync(@"..\..\..\result.jpg");
