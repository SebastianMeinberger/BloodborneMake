load("@rules_dotnet//dotnet:defs.bzl", "csharp_library")
load("@rules_antlr//antlr:antlr4.bzl", "antlr")
#load("@bazel_skylib//rules:select_file.bzl", "select_file")


antlr(
	name = "genESDParser",
	srcs = ["ESDLexer.g4","ESDParser.g4"],
	language = "CSharp"
)

#select_cs(name = "test", srcs = ":genESDParser", subpath = "/ESDParserListener.cs")


csharp_library(
	name = "libESDParser",
	srcs = [":genESDParser"], #[":genESDParser"],
	target_frameworks = ["netstandard2.1"],
	visibility = ["//visibility:public"],
	deps = ["@paket.main//antlr4.runtime.standard"]
)
