load("@rules_dotnet//dotnet/private/rules/csharp:library.bzl", "csharp_library")

csharp_library(
	name = "SoulsFormats",
	srcs = glob(["SoulsFormats/*/**/*.cs"]),
	target_frameworks = ["net8.0"],
	deps = ["@paket.main//zstdsharp.port"],
	visibility = ["//visibility:public"]
)
