class Unit
private
  class Inventory
    def initialize(items)
      @str = "["
      count = 0
      items.each_value do |item|
        if count == 0
          @str += "#{item}"
        elsif count < 4
          @str += ",#{item}"
        else
          $stderr.puts 'Warning: more than 4 items. Ignoring'
        end
        count += 1
      end
     @str += "]"
    end

    def to_s
      @str
    end
  end
public
  def initialize(data, game, leader)
    @game = game
    @leader = leader
    @name = data["Class"]
    @inventory = Inventory.new(data["Items"])
  end

  def to_s
    case @game
    when :fe6, :fe7
      "#define Generic#@name(id,loadX,loadY,X,Y,lv,AI) UNIT id #@name #@leader lv [loadX,loadY] [X,Y] #@inventory AI"
    when :fe8
      "#define Generic#@name(id,loadX,loadY,amount,redaPtr,lv,AI) UNIT id #@name #@leader lv [loadX,loadY] 0 0 amount redaPtr #@inventory AI"
    end
  end

end
