require 'yaml'
require './unit.rb'

default = YAML.load_file 'template.yml'

out = open 'generic_enemies.event', 'w'

out.puts '#ifndef __GENERIC_ENEMIES_EVENT__'
out.puts '#define __GENERIC_ENEMIES_EVENT__'
out.puts

default['Classes'].each_value do |_class|
  out.puts (Unit.new _class, default['Game'], default['Leader'])
end

out.puts
out.puts '#endif //__GENERIC_ENEMIES_EVENT__'
