Vagrant.configure("2") do |config|

  config.vm.box = "wheezy64-mono3.0.10-fsharp3.0.27"
  config.vm.box_url = "https://dl.dropboxusercontent.com/s/uelesklqouaw1gl/wheezy64-mono3.0.10-fsharp3.0.27-virtualbox.box"

  config.vm.provider :virtualbox do |vb|
  vb.gui = false
  vb.customize ["modifyvm", :id, "--memory", "1024"]
  vb.customize ["modifyvm", :id, "--cpus", "2"]
  end
end