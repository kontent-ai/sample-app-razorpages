﻿dotnet tool restore
$OUTPUT_PATH = Join-Path $PSScriptRoot "..\Models"
dotnet tool run KontentModelGenerator -p "975bf280-fd91-488c-994c-2f04416e5ee3" -o $OUTPUT_PATH -s true -n "kontent_sample_app_razorpages.Models" 