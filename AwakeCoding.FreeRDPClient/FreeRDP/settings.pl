#!/usr/bin/perl

open(FILE, 'settings.txt');

print "using System;\n";
print "using System.Collections.Generic;\n";
print "using System.Linq;\n";
print "using System.Text;\n";
print "\n";
print "namespace AwakeCoding.FreeRDPClient.FreeRDP\n";
print "{\n";
print "\tpublic sealed class FreeRDPSettings\n";
print "\t{\n";
print "\t\tprivate IntPtr settings;\n";
print "\n";
print "\t\tpublic FreeRDPSettings(IntPtr wfi)\n";
print "\t\t{\n";
print "\t\t\tthis.settings = NativeMethods.freerdp_client_get_settings(wfi);\n";
print "\t\t}\n";
print "\n";
while (<FILE>)
{
     $line = $_;

     if ($line =~ m/ (\S+) (\w+); \/\* (\d+) \*\//)
     {
         $type = $1;
         $name = $2;
         $number = $3;
         $const = "FreeRDP_$name";
		 $cstype = "";
		
         # c# getter/setter

        if ($type eq "UINT32") {
			$cstype = "uint";
			$fcttype = "uint32";
		}

		if ($type eq "UINT64") {
			$cstype = "ulong";
			$fcttype = "uint64";
		}

		if ($type eq "BOOL") {
			$cstype = "bool";
			$fcttype = "bool";
		}

		if ($type eq "char*") {
			$cstype = "string";
			$fcttype = "string";
		}
		
		if ($cstype ne "")
		{
print "\t\tpublic $cstype $name\n";
print "\t\t{\n";
print "\t\t\tget\n";
print "\t\t\t{\n";
print "\t\t\t\treturn NativeMethods.freerdp_get_param_$fcttype(settings, $number);\n";
print "\t\t\t}\n";
print "\t\t\tset\n";
print "\t\t\t{\n";
print "\t\t\t\tNativeMethods.freerdp_set_param_$fcttype(settings, $number, value);\n";
print "\t\t\t}\n";
print "\t\t}\n";
print "\n";
		}

     }
}

print "\t}\n";
print "}\n";


close(FILE);
exit;