// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ToTheDownStair : ModuleRules
{
	public ToTheDownStair(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
