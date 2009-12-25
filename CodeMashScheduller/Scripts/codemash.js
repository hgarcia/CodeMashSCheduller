$('a.clickable').each(function() {
    $(this).qtip({
        content: $(this).attr('tooltip'), // Use the tooltip attribute of the element for the content
        style: { name: 'dark', border: { radius: 5 }, width: { max: 500} },
        show: { when: 'click', solo: true }, // Give it a crea mstyle to make it stand out
        hide: { when: 'mouseout', fixed: true },
        position: { adjust: { screen: true} }
    });
});