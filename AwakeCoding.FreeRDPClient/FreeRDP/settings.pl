#!/usr/bin/perl

open(FILE, 'settings.h');

$keys = "";
$properties = "";
$first = 1;

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
			# Enum declarations
			if ($first == 1)
			{
				$keys = $keys . "\t\t\t" . $name . " = " . $number;
				$first = 0;
			}
			else
			{
				$keys = $keys . ",\n\t\t\t" . $name . " = " . $number;
			}

			# Property declarations		

			$properties = $properties . "\t\tpublic $cstype $name\n";
			$properties = $properties . "\t\t{\n";
			$properties = $properties . "\t\t\tget\n";
			$properties = $properties . "\t\t\t{\n";
			$properties = $properties . "\t\t\t\treturn NativeMethods.freerdp_get_param_$fcttype(settings, (int) Keys.$name);\n";
			$properties = $properties . "\t\t\t}\n";
			$properties = $properties . "\t\t\tset\n";
			$properties = $properties . "\t\t\t{\n";
			$properties = $properties . "\t\t\t\tNativeMethods.freerdp_set_param_$fcttype(settings, (int) Keys.$name, value);\n";
			$properties = $properties . "\t\t\t}\n";
			$properties = $properties . "\t\t}\n";
			$properties = $properties . "\n";
		}
     }
}

print "using System;\n";
print "using System.Collections.Generic;\n";
print "using System.Linq;\n";
print "using System.Text;\n";
print "\n";
print "namespace AwakeCoding.FreeRDPClient.FreeRDP\n";
print "{\n";
print "\tpublic sealed class FreeRDPSettings\n";
print "\t{\n";
print "\t\tpublic enum Keys\n";
print "\t\t{\n";
print $keys . "\n";
print "\t\t}\n";

print "\t\n";
print "\t\tprivate IntPtr settings;\n";
print "\n";
print "\t\tpublic FreeRDPSettings(IntPtr wfi)\n";
print "\t\t{\n";
print "\t\t\tthis.settings = NativeMethods.freerdp_client_get_settings(wfi);\n";
print "\t\t}\n";
print "\n";

print $properties;

print "\t}\n";
print "\n";
print "\tpublic delegate void FreeRDPSettingsChangedEventHandler(object sender, FreeRDPSettingsChangedEventArgs e);\n";
print "\n";
print "\tpublic class FreeRDPSettingsChangedEventArgs : EventArgs\n";
print "\t{\n";
print "\t\tpublic FreeRDPSettings.Keys Property  {get;set;}\n";
print "\t}\n";
print "\n";
print "}\n";

close(FILE);
exit;