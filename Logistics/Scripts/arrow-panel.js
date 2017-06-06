(function () {
    $(document).on('click', '.clickable', function (e) {
        var $this = $(this);

        if ($this.find('i').hasClass('glyphicon-chevron-up')) {
            $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
        }
        else if ($this.find('i').hasClass('glyphicon-chevron-down')) {
            $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
        }
    })
})();