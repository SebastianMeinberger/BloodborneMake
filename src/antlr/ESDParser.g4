parser grammar ESDParser;

options {tokenVocab = ESDLexer;}

file:	SHORTF headerShort
	|	LONGF headerLong
	;

headerLong:	INT1;
headerShort: TEMP;
