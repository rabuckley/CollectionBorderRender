﻿using Microsoft.Extensions.Logging;

namespace CollectionBorderRender;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if IOS || MACCATALYST
		builder.ConfigureMauiHandlers(handlers =>
		{
			handlers.AddHandler<CollectionView, Microsoft.Maui.Controls.Handlers.Items2.CollectionViewHandler2>();
		});
#endif

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}