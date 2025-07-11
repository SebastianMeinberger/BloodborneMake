load("@rules_dotnet//dotnet:defs.bzl", "csharp_binary")

csharp_binary(
	name = "fromscript2gd",
	srcs = glob(["*.cs"]),
	target_frameworks = ["net8.0"],
	deps = [
	"@SoulsFormats//:SoulsFormats",
	"@//src/antlr:libESDParser"]
)
