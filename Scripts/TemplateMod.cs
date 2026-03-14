using System.Net;
using Godot;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.RelicPools;

namespace doctornoodlearms.TemplateMod;

[ModInitializer("Init")]
public static class TemplateMod {

	public static void Init(){

		// RELIC REQUIRMENTS

		// Load the relic atlas table
		AtlasManager.LoadAtlas("template-mod-relic_atlas");

		// Load the relic outline atlas table
		AtlasManager.LoadAtlas("template-mod-relic_outline_atlas");

		// Add the relic to a pool
		// Doesnt seem to be loadable without doing this
		ModHelper.AddModelToPool<FallbackRelicPool, BasicRelic>();

		// Currently just been giving myself a custom relic with the DevConsole
	}
}
