def addition(a, b)
  print "a + b = #{a + b}\n"
end

def subtraction(a, b)
  print "a - b = #{a - b}\n"
end

def multiplication(a, b)
  print "a x b = #{a * b}\n"
end

def division(a, b)
  if b == 0 then
    print "Oops, you cannot divide by 0!\n"
  else
    print "a / b = #{a / b}\n"
  end
end

print "Four arithmetic operations on a and b\nEnter values\n"
puts "Which calculations do you want to output?\n"
puts "0. addition\n"
puts "1. subtraction\n"
puts "2. multiplication\n"
puts "3. division\n"
puts "Except 0 to 3. All\n"
print "Enter a number: "
outputFormat = gets.to_i
print "a = "
a = gets.to_f
print "b = "
b = gets.to_f

case outputFormat
when 0 then
  addition(a, b)
when 1 then
  subtraction(a, b)
when 2 then
  multiplication(a, b)
when 3 then
  division(a, b)
else
  addition(a, b)
  subtraction(a, b)
  multiplication(a, b)
  division(a, b)
end