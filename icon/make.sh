#!/bin/bash

do_resize(){

	sizes="16 32 48 64 128 256"

	for size in $sizes
    do
        inkscape icon.svg --export-area-page --export-png icon-$size.png --export-width $size --export-height $size > /dev/null 2> /dev/null
        echo -n "$size "
    done
	echo "ok"
	inkscape icon.svg --export-area-page --export-pdf icon-full.pdf > /dev/null 2> /dev/null
	convert icon-*.png wol.ico
}

new_colors(){
	colors_green="s/_DO_NOTHING//"
	colors_yellow="s/#4cf800/#fff900/g; s/#366d1e/#887700/g"
	colors_red="s/#4cf800/#ee2211/g; s/#366d1e/#881100/g"
	colors_orange="s/#4cf800/#ff6611/g; s/#366d1e/#883300/g"
	colors_blue="s/#4cf800/#1111ee/g; s/#366d1e/#000088/g"
	colors_pink="s/#4cf800/#ff3690/g; s/#366d1e/#6f1c41/g"
	
	for color in green blue yellow red orange pink
	do
		echo "color: $color"
		varname="colors_${color}"
		[ -e color-$color ] || mkdir color-$color
		cat icon.svg | sed -e "${!varname}" > color-$color/icon.svg
		cd color-$color
		do_resize
		cd ..
		mv color-$color/wol.ico wol-$color.ico
	done
}

new_colors
