// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjetPlat3D : ModuleRules
{
	public ProjetPlat3D(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
