f = open 'fe7Pointers.txt'
out = open 'fe7ChapterIndex.event', 'w'

out.puts '#ifndef __FE7CHAPTERINDEX_EVENT__'
out.puts '#define __FE7CHAPTERINDEX_EVENT__'
out.puts

f.each_line do |line|
  if line =~ /.*Event.*/
    data = line.split
    value = data[0]
    macro = data[1].gsub(/[\/.]/, {'.' => '', '/' => '_'})
    out.puts "#define #{macro}Idx #{value}"
  end
end

out.puts
out.puts '#endif //__FE7CHAPTERINDEX_EVENT__'
